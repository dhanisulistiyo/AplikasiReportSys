using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppReportSystem.Model;

namespace AppReportSystem
{
    public class ReportController
    {
        StudentController stcu = new StudentController();
        SubjectController sbcu = new SubjectController();
        SchoolContext db = new SchoolContext();
        

        public void inputScoreReport()
        {

            back:

            Console.WriteLine("Silahkan masukkan teacher ID ");
            string teacherID = Console.ReadLine();

            Console.WriteLine("Silahkan masukkan student ID ");
            string studentID = Console.ReadLine();

            if (stcu.searchstudent(studentID) == 1)
            {
                Console.WriteLine("Berikut adalah subject yang tersedia : ");
                sbcu.printSubject();
                Console.WriteLine("Silahkan masukkan nilai untuk masing - masing mata pelajaran");
                
                int subjectQty = db.Subjects.Count();
                int score;

                Report myReport = new Report(studentID,teacherID);
                

                for (int  i = 0;i<subjectQty;i++)
                {
                    Console.WriteLine("Masukkan nilai untuk mata pelajaran {0}",i);

                }


            }
            else
            {
                Console.WriteLine("Id tidak tersedia");
                goto back;
            }
        }

    }
}
