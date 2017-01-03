using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppReportSystem.Model
{
    public class ReportDetail : Report
    {
        public string subjectID;
        public string score;


        public ReportDetail(string subjectID,string scoreID, string studentID, string teacherID) : base(studentID,teacherID)
        {
            this.subjectID = subjectID;
            this.score = scoreID;
        }

    }
}
