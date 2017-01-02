using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppReportSystem.Model
{
   public class Teachers : Person
    {
        public string ofClass { get; set; }

        public Teachers(string name, string id, DateTime birth, string gender, string kelas) : base(name, id, birth, gender)
        {
            this.ofClass = kelas;
        }
    }
}
