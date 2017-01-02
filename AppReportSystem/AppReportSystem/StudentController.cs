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
        public void inputStudent()
        {
            Console.Clear();
            string nama, id, tgl_lahir, jk, kelas;
            Console.Write("Berapa banyak data Siswa yang dimasukkan : ");
            string num = Console.ReadLine();

            for (i = 1; i <= Convert.ToInt32(num); i++)
            {
                Console.Clear();
                Console.WriteLine("========= Input Data Siswa " + i + " ==========");
                Console.Write("Masukkan Nama : ");
                nama = Console.ReadLine();
                Console.Write("Masukkan ID : ");
                id = Console.ReadLine();
                Console.Write("Masukkan Tanggal Lahir : ");
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


    }
}
