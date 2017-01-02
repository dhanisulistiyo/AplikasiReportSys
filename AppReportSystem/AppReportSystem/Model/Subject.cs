using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppReportSystem.Model
{
    public class Subject
    {
        public string Name { get; set; }
        public string IdSubject { get; set; }

        public Subject()
        {
        }
        public Subject(string name, string id)
        {
            this.Name = name;
            this.IdSubject = id;
        }
    }
}
