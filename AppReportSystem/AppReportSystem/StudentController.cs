
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppReportSystem.Model;


namespace AppReportSystem
{
    public class StudentController 
    {
        SchoolContext db = new SchoolContext();
        int i;
        string nama, id, tgl_lahir, jk, kelas, num, answer;

        //Create Student
        public void inputStudent()
        {
            Console.Clear();
            
            Console.Write("Berapa banyak data Siswa yang dimasukkan : ");
            num = Console.ReadLine();
            for (i = 1; i <= Convert.ToInt32(num); i++)
            {
                Console.Clear();
                Console.WriteLine("========= Input Data Siswa " + i + " ==========");
                Console.Write("Masukkan Nama : ");
                nama = Console.ReadLine();
                Console.Write("Masukkan ID : ");
                id = Console.ReadLine();
                Console.Write("Masukkan Tanggal Lahir (yyyy-mm-dd): ");
                tgl_lahir = Console.ReadLine();
                Console.Write("Jenis Kelamin : ");
                jk = Console.ReadLine();
                Console.Write("Masukkan Kelas : ");
                kelas = Console.ReadLine();
                Student t = new Student(nama, id, Convert.ToDateTime(tgl_lahir), jk, kelas);
                db.Students.Add(t);
                db.SaveChanges();
            }
        }


        //View Student
        public void printStudent()
        {
            Console.Clear();
            var query = from stu in db.Students
                        select new {
                            stu.Id,
                            stu.Name,
                            stu.DateOfBirth,
                            stu.Gender,
                            stu.ofClass
                        };

            Console.WriteLine("All Data in the database:");
            Console.WriteLine("|===ID===|===============Nama===============|");
            foreach (var item in query)
            {
                i = 0; i++;
                Console.Write("    "+item.Id);
                Console.WriteLine("      "+item.Name);
                Console.WriteLine();
                
             }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
        //Delete
        public void delStudent()
        {
            back:
            Console.Clear();
            Console.Write(" Masukkan ID Students: ");
            num = Console.ReadLine();

            if (searchstudent(num) == 1)
            {
                sub:
                this.searchstudent(num);
                Console.WriteLine("Cek isi data. Lanjutkan Hapus data? y or n");
                answer = Console.ReadLine();
                if (answer.ToLower() == "y")
                {
                    Console.Clear();
                    Student c = (from x in db.Students
                                 where x.Id == num
                                 select x).First();
                    db.Students.Remove(c);
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
        public void editStudent()
        {
            back:
            Console.Clear();
            Console.Write(" Masukkan ID Students: ");
            num = Console.ReadLine();
            
            if (searchstudent(num) != null)
            {
                sub:
                this.searchstudent(num);
                Console.WriteLine("Cek isi data. Lanjutkan Edit data? y or n");
                answer = Console.ReadLine();
                if (answer.ToLower() == "y")
                {
                    Console.Clear();
                    Student c = (from x in db.Students
                                 where x.Id == num
                                 select x).First();

                    Console.Write("Masukkan Nama : ");
                    nama = Console.ReadLine();
                    Console.Write("Masukkan Tanggal Lahir (yyyy-mm-dd): ");
                    tgl_lahir = Console.ReadLine();
                    Console.Write("Jenis Kelamin : ");
                    jk = Console.ReadLine();
                    Console.Write("Masukkan Kelas : ");
                    kelas = Console.ReadLine();

                    if (nama != "")
                        c.Name = nama;
                    if (tgl_lahir != "")
                        c.DateOfBirth = Convert.ToDateTime(tgl_lahir);
                    if (jk != "")
                        c.Gender = jk;
                    if (kelas != "")
                        c.ofClass = kelas;

                    db.SaveChanges();
                    Console.Clear();
                    Console.WriteLine("Data saved....");
                    Console.ReadLine();
                    searchstudent(num);
                    Console.WriteLine("Kembali edit data? y or n");
                    answer = Console.ReadLine();
                    if (answer.ToLower() == "y")
                    {
                        goto back;
                    }
                    else
                    {
                          //exit
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
        public int searchstudent(string id) {

            var query = from stu in db.Students
                        where (stu.Id.Equals(id))
                        select new
                        {
                            stu.Id,
                            stu.Name,
                            stu.DateOfBirth,
                            stu.Gender,
                            stu.ofClass
                        };
            foreach (var item in query)
            {
                Console.Clear();
                Console.WriteLine("ID               : " + item.Id);
                Console.WriteLine("Nama             : " + item.Name);
                Console.WriteLine("Tanggal Lahir    : " + item.DateOfBirth);
                Console.WriteLine("Jenis Kelamin    : " + item.Gender);
                Console.WriteLine("Kelas            : " + item.ofClass);
                
            }
            if (query.Count() == 0)
                return 0;
            else
                return 1;
        }

    }
}
