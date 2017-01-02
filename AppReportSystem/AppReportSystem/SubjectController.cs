using AppReportSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppReportSystem
{
    public class SubjectController
    {
        SchoolContext db = new SchoolContext();
        int i;
        string nama, id, num, answer;
        //Create Student
        public void inputSubject()
        {
            Console.Clear();

            Console.Write("Berapa banyak data Mata Pelajaran yang dimasukkan : ");
            num = Console.ReadLine();
            for (i = 1; i <= Convert.ToInt32(num); i++)
            {
                Console.Clear();
                Console.WriteLine("========= Input Data Mata Pelajaran " + i + " ==========");
                Console.Write("Masukkan Nama Mata Pelajaran : ");
                nama = Console.ReadLine();
                Console.Write("Masukkan ID : ");
                id = Console.ReadLine();               
                Subject t = new Subject(nama, id);
                db.Subjects.Add(t);
                db.SaveChanges();
            }
        }
        //View Student
        public void printSubject()
        {
            Console.Clear();
            var query = from su in db.Subjects
                        select new
                        {
                            su.IdSubject,
                            su.Name                           
                        };
            Console.WriteLine("|===ID===|=========Nama Mata Pelajaran==========|");
            foreach (var item in query)
            {
                i = 0;
                i++;
                Console.Write("    " + item.IdSubject);
                Console.WriteLine("      " + item.Name);
                Console.WriteLine();
            }
            Console.WriteLine("Press any key to exit...");
            Console.ReadLine();
        }
        //Delete
        public void delSubject()
        {
            back:
            Console.Clear();
            Console.Write(" Masukkan ID Mata Pelajaran: ");
            num = Console.ReadLine();

            if (searchsubject(num) == 1)
            {
                sub:
                this.searchsubject(num);
                Console.WriteLine("Cek isi data. Lanjutkan Hapus data? y or n");
                answer = Console.ReadLine();
                if (answer.ToLower() == "y")
                {
                    Console.Clear();
                    Subject c = (from x in db.Subjects
                                 where x.IdSubject == num
                                 select x).First();
                    db.Subjects.Remove(c);
                    db.SaveChanges();
                    Console.WriteLine("Data has been deleted ................");
                    Console.ReadLine();
                }
                else if (answer.ToLower() == "n")
                {
                    goto back;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Input Salah....");
                    Console.ReadLine();
                    goto sub;
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Id yang dimasukkan salah................");
                Console.ReadLine();
                goto back;
            }
        }
        //Delete
        public void editSubject()
        {
            back:
            Console.Clear();
            Console.Write(" Masukkan ID Students: ");
            num = Console.ReadLine();

            if (searchsubject(num) != null)
            {
                sub:
                this.searchsubject(num);
                Console.WriteLine("Cek isi data. Lanjutkan Edit data? y or n");
                answer = Console.ReadLine();
                if (answer.ToLower() == "y")
                {
                    Console.Clear();
                    Subject c = (from x in db.Subjects
                                 where x.IdSubject == num
                                 select x).First();

                    Console.Write("Masukkan Nama : ");
                    nama = Console.ReadLine();

                    if (nama != "")
                        c.Name = nama;
                
                    db.SaveChanges();

                    Console.Clear();
                    Console.WriteLine("Data saved....");
                    Console.ReadLine();
                    searchsubject(num);
                    Console.WriteLine("Kembali edit data? y or n");
                    answer = Console.ReadLine();
                    if (answer.ToLower() == "y")
                    {
                        goto back;
                    }
                    else
                    {
                        return;
                    }

                }
                else if (answer.ToLower() == "n")
                {
                    goto back;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Input Salah....");
                    Console.ReadLine();
                    goto sub;
                }
            }
            else
            {
                Console.WriteLine("Id yang dimasukkan salah................");
                Console.ReadLine();
                goto back;
            }
        }
        //Search
        public int searchsubject(string id)
        {

            var query = from su in db.Subjects
                        where (su.IdSubject.Equals(id))
                        select new
                        {
                            su.IdSubject,
                            su.Name     
                        };
            foreach (var item in query)
            {
                Console.Clear();
                Console.WriteLine("ID               : " + item.IdSubject);
                Console.WriteLine("Nama             : " + item.Name);
            }
            if (query.Count() == 0)
                return 0;
            else
                return 1;
        }

    }
}
