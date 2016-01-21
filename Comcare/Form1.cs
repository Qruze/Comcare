using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Comcare.DoingStuff;
using System.Diagnostics;
using Comcare.Models;

namespace Comcare
{
    public partial class Form1 : Form
    {
        DataTable test;
        
        public Form1()
        {
            InitializeComponent();

            test = new DataTable();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //partProjectsBindingSource.DataSource = Loading.LoadData(dataSet1);
            //dataSet1 = Loading.LoadData(dataSet1);
            
            dataSet1.Tables[1].RowChanged += table_RowChanged;
            dataSet1.Tables[1].RowChanging += table_RowChanging;
            
        }

        static void table_RowChanging(object sender, DataRowChangeEventArgs e)
        {
            Loading load = new Loading();
            Trace.WriteLine(string.Format("DataTable_RowChanging(): Action {0}, RowState {1}", e.Action, e.Row.RowState));

            if (e.Action == DataRowAction.Add)
            {
                e.Row.ClearErrors();

                DataTable updateDataTable = load.RecalcData(sender as DataTable);
                
            }

            if (e.Action == DataRowAction.Change)
            {
                e.Row.ClearErrors();
                DataTable updateDataTable = load.RecalcData(sender as DataTable);
            }
        }

        static void table_RowChanged(object sender, DataRowChangeEventArgs e)
        {            
            Trace.WriteLine(string.Format("DataTable_RowChanged(): Action {0}, RowState {1}", e.Action, e.Row.RowState));

            if (e.Action == DataRowAction.Add)
            {
                e.Row.AcceptChanges();
            }

            if (e.Action == DataRowAction.Change)
            {
                e.Row.AcceptChanges();

            }
        }

        

        private void btn_CreateMainProject_Click(object sender, EventArgs e)
        {
            if (dataSet1.Tables.Contains("MainProjects"))
            {
                if (string.IsNullOrEmpty(txtBox_NewProjectName.Text))
                {
                    lbl_MainProjectStatus.Visible = true;
                    lbl_MainProjectStatus.Text = "Error when adding new MainProject. No name given!!!";
                }
                else
                {
                    DataRow row = dataSet1.Tables[0].NewRow();
                    row["Name"] = txtBox_NewProjectName.Text;
                    dataSet1.Tables["MainProjects"].Rows.Add(row);
                }
            }
            else
            {
                lbl_MainProjectStatus.Visible = true;
                lbl_MainProjectStatus.Text = "Error when adding new MainProject. DataTable MainProjects does not exsist!!!";
            }

            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Loading load = new Loading();
            var foo = (BindingSource)dataGridView1.DataSource;
            
            var test = (DataSet1)foo.DataSource;
            DataTable test2 = load.RecalcData(test.Tables[1]);
            foo.DataSource = test2;
            dataGridView1.DataSource = foo;
            dataGridView1.Refresh();
        }
    }
}
