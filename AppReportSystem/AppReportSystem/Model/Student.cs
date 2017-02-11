using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppReportSystem.Model
{
    public class Student : Person
    {

        public string ofClass { get; set; }

        public Student() : base() {
             
        }
        public Student(string name, string id, DateTime birth, string gender, string kelas) : base(name, id, birth, gender)
        {
            this.ofClass = kelas;
        }
    }
}
