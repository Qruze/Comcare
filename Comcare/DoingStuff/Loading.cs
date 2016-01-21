using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Comcare.Models;

namespace Comcare.DoingStuff
{
    class Loading
    {
        public DataTable RecalcData(DataTable _dataTable)
        {
            DataTable copyDataTable = _dataTable.Clone();

            DataRow startRow = _dataTable.Rows[0];
            DateTime startDate = startRow.Field<DateTime>("startDate");

            bool firstRow = true;

            var nextDate1 = NextAvailDate(startDate, startRow.Field<int>("length"), startRow.Field<bool>("onlyWorkDays"));
            var endDate = EndDate(nextDate1, startRow.Field<bool>("onlyWorkDays"));

            int columnCount = _dataTable.Columns.Count;

            foreach (DataRow row in _dataTable.Rows)
            {
                DataRow copyRow = copyDataTable.NewRow();

                copyRow[1] = row[1];
                copyRow[2] = row[2];
                copyRow[4] = row[4];
                copyRow[5] = row[5];

                if (firstRow)
                {
                    copyRow[3] = startDate;
                    copyRow[6] = endDate;
                    firstRow = false;
                }
                else
                {
                    copyRow[3] = startDate = EndDate(endDate.AddDays(1), (bool)copyRow[5]);
                    copyRow[6] = endDate = NextAvailDate(((DateTime)copyRow[3]).AddDays(-1), (int)copyRow[4], (bool)copyRow[5]);
                }

                copyDataTable.Rows.Add(copyRow);
                
            }
            return copyDataTable;
        }
        public static DataSet1 LoadData(DataSet1 dataSet1)
        {
            if (dataSet1.Tables.Contains("MainProjects") && dataSet1.Tables.Contains("PartProjects"))
            {
                DataTable dtMain;
                DataTable dtPart;

                dtMain = dataSet1.Tables["MainProjects"];
                dtPart = dataSet1.Tables["PartProjects"];

                dtMain.Rows.Add(1, "TestProject");

                var startDate = new DateTime(2016, 01, 18);
                var nextDate1 = NextAvailDate(startDate, 6, true);
                var endDate1 = EndDate(nextDate1, true);

                var nextDate2 = EndDate(endDate1.AddDays(1),  false);
                var endDate2 = NextAvailDate(nextDate2.AddDays(-1), 5, false);

                var nextDate3 = EndDate(endDate2.AddDays(1),  true);
                var endDate3 = NextAvailDate(nextDate3.AddDays(-1),1, true);

                dtPart.Rows.Add(1, 1, "Delmål1", startDate, 6, true, endDate1);
                dtPart.Rows.Add(2, 1, "Delmål2", nextDate2, 5, false, endDate2);
                dtPart.Rows.Add(3, 1, "Delmål3", nextDate3, 1, true, endDate3);
            }

            return dataSet1;
        }

        public static DateTime NextAvailDate(DateTime startDate, int numOfDays, bool onlyWorkDays)
        {


            DateTime nextAvail = startDate.AddDays(numOfDays);

            if (onlyWorkDays && nextAvail.DayOfWeek == DayOfWeek.Saturday)
            {
                nextAvail = nextAvail.AddDays(2);
            }
            else if (onlyWorkDays && nextAvail.DayOfWeek == DayOfWeek.Sunday)
            {
                nextAvail = nextAvail.AddDays(1);
            }

            return nextAvail;
        }
        public static DateTime EndDate(DateTime endDate, bool onlyWorkDays)
        {
            if (onlyWorkDays && endDate.DayOfWeek == DayOfWeek.Saturday)
            {
                endDate = endDate.AddDays(2);
            }
            else if (onlyWorkDays && endDate.DayOfWeek == DayOfWeek.Sunday)
            {
                endDate = endDate.AddDays(1);
            }

            return endDate;
        }

    }
}
