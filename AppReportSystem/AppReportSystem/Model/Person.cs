using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppReportSystem.Model
{
    public class Person
    {
        public string Name { get; set; }
        public string Id { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }

        public Person(string name, string id, DateTime birth, string gender)
        {
            this.Name = name;
            this.Id = id;
            this.DateOfBirth = birth;
            this.Gender = gender;
        }
    }
}
