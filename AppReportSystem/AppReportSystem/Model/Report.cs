using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppReportSystem.Model
{
    public class Report
    {
        public string studentID;
        public string teacherID;


        public Report(string studentID, string teacherID)
        {
            this.studentID = studentID;
            this.teacherID = teacherID;
        }

    }
}
