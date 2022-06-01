using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_OxfordAcademy.Classes
{
    class TeacherInformation
    {
        ObservableCollection<Teacher> teachers;
        public TeacherInformation()
        {
            this.teachers = new ObservableCollection<Teacher>()
            {
                new Teacher{ ID=1, Name="Lotus Jacob",DateofBirth=new DateTime(1996, 02, 12),BloodGroup="A+", JoiningDate=new DateTime(2022, 02, 12),Subject="Mathematics", Salary=890000.00M, Post="Assistant Lecturer",isContinuing=true, Image="Assets/1.jpg"},
                new Teacher{ ID=2, Name="Amy Smith",DateofBirth=new DateTime(1998, 02, 12),BloodGroup="B+", JoiningDate=new DateTime(2022, 03, 12),Subject="English", Salary=890000.00M, Post="Assistant Lecturer", Image="Assets/6.jpg"},
                new Teacher{ ID=3, Name="Helen Levings",DateofBirth=new DateTime(1994, 02, 12),BloodGroup="AB+", JoiningDate=new DateTime(2021, 10, 12),Subject="Social Science", Salary=890000.00M, Post="Lecturer",isContinuing=true  ,Image="Assets/2.jpg"},
                new Teacher{ ID=4, Name="Jean Rash",DateofBirth=new DateTime(1992, 02, 12),BloodGroup="A-",  JoiningDate=new DateTime(2021, 05, 12),Subject="Mathematics", Salary=890000.00M, Post="Lecturer", isContinuing=true ,Image="Assets/7.jpg"},
                new Teacher{ ID=5, Name="Edna Francis",DateofBirth=new DateTime(1990, 02, 12),BloodGroup="O+", JoiningDate=new DateTime(2020, 10, 12),Subject="Drawing", Salary=890000.00M, Post="Assistant Professor",Image="Assets/3.jpg"},
                new Teacher{ ID=6, Name="Wynona James", DateofBirth=new DateTime(1991, 02, 12),BloodGroup="O+", JoiningDate=new DateTime(2020, 10, 12),Subject="English", Salary=890000.00M, Post="Assistant Professor",isContinuing=true,Image="Assets/9.jpg"},
                new Teacher{ ID=7, Name="Gladys Swon", DateofBirth=new DateTime(1988, 02, 12),BloodGroup="AB-", JoiningDate=new DateTime(2019, 10, 12),Subject="ICT", Salary=890000.00M, Post="Professor", isContinuing=true,Image="Assets/4.jpg"},
                new Teacher{ ID=8, Name="Alex Pol",DateofBirth=new DateTime(1989, 02, 12),BloodGroup="A+", JoiningDate=new DateTime(2019, 10, 12),Subject="Social Science", Salary=890000.00M, Post="Professor",isContinuing=true, Image="Assets/10.jpg"},
                new Teacher{ ID=9, Name="Moneaka Elam",DateofBirth=new DateTime(1986, 02, 12),BloodGroup="O-",  JoiningDate=new DateTime(2018, 01, 01),Subject="Accounting", Salary=890000.00M, Post="Professor",Image="Assets/5.jpg"},
                new Teacher{ ID=10,Name="Jhon Leo",DateofBirth=new DateTime(1986, 02, 12),BloodGroup="Ab+", JoiningDate=new DateTime(2017, 10, 12),Subject="Science", Salary=890000.00M, Post="Principal",isContinuing=true, Image="Assets/8.jpg"}
            };
        }
        public ObservableCollection<Teacher> Get()
        {
            return this.teachers;
        }
        public Teacher Get(int id)
        {
            return this.teachers.First(x => x.ID == id);
        }
    }
}
