using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Lab2
{
    public class Project
    {
        public Project() { }
        public Project(string name) {
            this.Project_name = name;
            Time_to_comp = 0;
            Number_of_emp = 0;
        }
        [Key]
        public string Project_name {  get; set; }
        public int Time_to_comp {  get; set; }
        public int Price { get; set; }
        public int Number_of_emp { get; set; }
    }
}
