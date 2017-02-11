using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppReportSystem.Model
{
    public class Subject
    {
        public string Name { get; set; }
        [Key]
        public string IdSubject { get; set; }
        public int NilaiKKM { get; set; }

        public Subject() : base()
        {
        }

        public Subject(string name, string id, int kkm)
        {
            this.Name = name;
            this.IdSubject = id;
            this.NilaiKKM = kkm;
        }
    }
}
