using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Students
{
   public class Student
    {
        public string FIO { get; set; }
        public string adres { get; set; }
        public int age { get; set; }
        public int stepuha { get; set; }


        public Student() { }
        public Student(string FIO,int age,string adres = "", int stepuha = 0)
            {
            this.FIO = FIO;
            this.adres = adres;
            this.age = age;
            this.stepuha = stepuha;

            }


    }
}
