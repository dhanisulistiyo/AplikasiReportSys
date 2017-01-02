using AppReportSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppReportSystem
{
   public class TeacherController
    {
        SchoolContext db = new SchoolContext();
        int i;
        string nama, id, num, answer, tgl_lahir, gender, kelas, ofClass, jk;
        //Input Teacher
        public void inputTeacher()
        {
            Console.Clear();

            Console.Write("Berapa banyak data Siswa yang dimasukkan : ");
            num = Console.ReadLine();
            Console.WriteLine();
            for (i = 1; i <= Convert.ToInt32(num); i++)
            {
                Console.Clear();
                Console.WriteLine("========= Input Data Guru " + i + " ==========");
                Console.WriteLine();
                Console.Write("Masukkan Nama : ");
                nama = Console.ReadLine();
                Console.WriteLine();
                Console.Write("Masukkan ID : ");
                id = Console.ReadLine();
                Console.WriteLine();
                Console.Write("Masukkan Tanggal Lahir (yyyy-mm-dd): ");
                tgl_lahir = Console.ReadLine();
                Console.WriteLine();
                Console.Write("Jenis Kelamin(L/P): ");
                jk = Console.ReadLine();
                Console.WriteLine();
                Console.Write("Masukkan Kelas : ");
                kelas = Console.ReadLine();
                Console.WriteLine();
                Teachers teaacher = new Teachers(nama, id, Convert.ToDateTime(tgl_lahir), jk, kelas);
                db.Teachers.Add(teaacher);
                db.SaveChanges();
            }
        }
        //View Teacher
        public void printTeacher()
        {
            Console.Clear();
            var query = from stu in db.Teachers
                        select new
                        {
                            stu.Id,
                            stu.Name,
                            stu.DateOfBirth,
                            stu.Gender,
                            stu.ofClass
                        };

            Console.WriteLine("Semua data di database:");
            Console.WriteLine("|===ID===|===============Nama===============|");
            foreach (var item in query)
            {
                i = 0; i++;
                Console.Write("    " + item.Id);
                Console.WriteLine("      " + item.Name);
                Console.WriteLine();

            }

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
        //Delete
        public void delTeacher()
        {
            back:
            Console.Clear();
            Console.Write(" Masukkan ID Guru: ");
            num = Console.ReadLine();

            if (searchstudent(num) == 1)
            {
                sub:
                this.searchstudent(num);
                Console.WriteLine("Cek isi data. Lanjutkan Hapus data? Y/N");
                answer = Console.ReadLine();
                if (answer.ToLower() == "y" || answer.ToLower() == "Y")
                {
                    Console.Clear();
                    Student c = (from x in db.Students
                                 where x.Id == num
                                 select x).First();
                    db.Students.Remove(c);
                    db.SaveChanges();
                    Console.WriteLine("Data telah dihapus");
                    Console.ReadLine();
                }
                else if (answer.ToLower() == "n" || answer.ToLower() == "N")
                {
                    goto back;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Data yang anda inputkan salah");
                    Console.ReadLine();
                    goto sub;
                }


            }
            else
            {
                Console.Clear();
                Console.WriteLine("ID yang anda inputkan tidak ada");
                Console.ReadLine();
                goto back;
            }


        }
        //Delete
        public void editTeacher()
        {
            back:
            Console.Clear();
            Console.Write(" Masukkan ID Guru: ");
            num = Console.ReadLine();

            if (searchstudent(num) != null)
            {
                sub:
                this.searchstudent(num);
                Console.WriteLine("Cek isi data. Lanjutkan Edit data? Y/N");
                answer = Console.ReadLine();
                if (answer.ToLower() == "y" || answer.ToLower() == "Y")
                {
                    Console.Clear();
                    Student c = (from x in db.Students
                                 where x.Id == num
                                 select x).First();

                    Console.Write("Masukkan Nama : ");
                    nama = Console.ReadLine();
                    Console.WriteLine();
                    Console.Write("Masukkan Tanggal Lahir (yyyy-mm-dd): ");
                    tgl_lahir = Console.ReadLine();
                    Console.WriteLine();
                    Console.Write("Jenis Kelamin : ");
                    jk = Console.ReadLine();
                    Console.WriteLine();
                    Console.Write("Masukkan Kelas : ");
                    kelas = Console.ReadLine();
                    Console.WriteLine();
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
                    Console.WriteLine("Data telah disimpan");
                    Console.ReadLine();
                    searchstudent(num);
                    Console.WriteLine("Kembali edit data?Y/N");
                    answer = Console.ReadLine();
                    if (answer.ToLower() == "y" || answer.ToLower() == "Y")
                    {
                        goto back;
                    }
                    else
                    {
                        return;
                    }

                }
                else if (answer.ToLower() == "n" || answer.ToLower() == "N")
                {
                    goto back;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Data yang anda inputkan salah");
                    Console.ReadLine();
                    goto sub;
                }
            }
            else
            {
                Console.WriteLine("ID yang anda inputkan salah");
                Console.ReadLine();
                goto back;



            }

        }
        //Search
        public int searchstudent(string id)
        {

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
