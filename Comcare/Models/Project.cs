using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comcare.Models
{
    public class Project
    {
        public int Id { get; set; }
        public List<PartProjects> PartProjects { get; set; }
    }


    public class PartProjects
    {
        public int PartId { get; set; }
        public int ProjectId { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public int Length { get; set; }
        public bool OnlyWorkDays { get; set; }
    }
}
