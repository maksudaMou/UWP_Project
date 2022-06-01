using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_OxfordAcademy.Classes
{
    public class Teacher
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime DateofBirth { get; set; }
        public string BloodGroup { get; set; }
        public DateTime JoiningDate { get; set; }
        public string Subject { get; set; }
        public Decimal Salary { get; set; }
        public string Post { get; set; }
        public string Image { get; set; }
        public bool isContinuing { get; set; } = false;
        public string JoinDate { get => JoiningDate.ToString("dddd, dd MMMM yyyy"); }
        public string DOB { get => JoiningDate.ToString("dddd, dd MMMM yyyy"); }
    }
}
