using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppReportSystem
{
    class Program
    {
         
        static void Main(string[] args)
        {
            BACK:
            Console.Clear();
            Console.WriteLine("\t\t=====================================");
            Console.WriteLine("\t\t==Aplikasi HR SMKN 1 Cikarang Barat==");
            Console.WriteLine("\t\t=====================================");
            Console.WriteLine();
            Console.WriteLine("Pilih menu yang tersedia!");
            Console.WriteLine("1. Input Data");
            Console.WriteLine("2. Lihat Data");
            Console.WriteLine("3. Edit Data");
            Console.WriteLine("4. Hapus Data");
            Console.WriteLine("5. Cetak Raport");
            Console.WriteLine("6. Keluar");
            Console.WriteLine();
            Console.Write("Masukkan nomor menu: ");
            var nomer = Console.ReadLine();
            if (nomer == "1")
            {
                inputData();
                goto BACK;
            }
            else if (nomer == "2")
            {
                viewData();
                goto BACK;
            }
            else if (nomer == "3")
            {
                editData();
                goto BACK;
            }
            else if (nomer == "4")
            {
                deleteData();
                goto BACK;
            }
            else if (nomer == "6")
            {
                printReport();
                goto BACK;
            }
            else if (nomer == "5")
            {
                return;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Maaf, nomor yang anda inputkan salah");
                Console.ReadLine();
                goto BACK;
            }
        }

        public static void inputData() {
            SubjectController pSub = new SubjectController();
            StudentController pStu = new StudentController();
            TeacherController pTea = new TeacherController();

            BACK:
            Console.Clear();
            Console.WriteLine("Pilih submenu input data yang tersedia!");
            Console.WriteLine("1. Input Data Siswa");
            Console.WriteLine("2. Input Data Guru");
            Console.WriteLine("3. Input Data Nilai");
            Console.WriteLine("4. Input Data Mata Pelajaran ");
            Console.WriteLine("5. Keluar");
            Console.Write("Masukkan nomor submenu: ");
            var nomer = Console.ReadLine();
            if (nomer == "1")
            {
                pStu.inputStudent();
                goto BACK;
            }
            else if (nomer == "2")
            {
                pTea.inputTeacher();
                goto BACK;
            }
            else if (nomer == "3")
            {
                editData();
                goto BACK;
            }
            else if (nomer == "4")
            {
                pSub.inputSubject();
                goto BACK;
            }
            else if (nomer == "5")
            {
                return;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Maaf, nomor yang anda inputkan salah");
                Console.ReadLine();
                goto BACK;
            }
        }
        public static void viewData() {
            SubjectController pSub = new SubjectController();
            StudentController pStu = new StudentController();
            TeacherController pTea = new TeacherController();
            BACK:
            Console.Clear();
            Console.WriteLine("Pilih submenu lihat data yang tersedia!");
            Console.WriteLine("1. Lihat Data Siswa");
            Console.WriteLine("2. Lihat Data Guru");
            Console.WriteLine("3. Lihat Data Nilai");
            Console.WriteLine("4. Lihat Data Mata Pelajaran ");
            Console.WriteLine("5. Keluar");
            Console.Write("Masukkan nomor submenu: ");
            var nomer = Console.ReadLine();
            if (nomer == "1")
            {
                pStu.printStudent();
                goto BACK;
            }
            else if (nomer == "2")
            {
                pTea.printTeacher();
                goto BACK;
            }
            else if (nomer == "3")
            {
                
                goto BACK;
            }
            else if (nomer == "4")
            {
                pSub.printSubject();
                goto BACK;
            }
            else if (nomer == "5")
            {
                return;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Maaf, nomor yang anda inputkan salah");
                Console.ReadLine();
                goto BACK;
            }
        }
        public static void editData() {
            BACK:
            SubjectController pSub = new SubjectController();
            StudentController pStu = new StudentController();
            TeacherController pTea = new TeacherController();
            Console.Clear();
            Console.WriteLine("Pilih submenu edit data yang tersedia!");
            Console.WriteLine("1. Edit Data Siswa");
            Console.WriteLine("2. Edit Data Guru");
            Console.WriteLine("3. Edit Data Nilai");
            Console.WriteLine("4. Edit Data Mata Pelajaran ");
            Console.WriteLine("5. Keluar");
            Console.Write("Masukkan nomor submenu: ");
            var nomer = Console.ReadLine();
            if (nomer == "1")
            {
                pStu.editStudent();
                goto BACK;
            }
            else if (nomer == "2")
            {
                pTea.editTeacher();
                goto BACK;
            }
            else if (nomer == "3")
            {
                editData();
                goto BACK;
            }
            else if (nomer == "4")
            {
                pSub.editSubject();
                goto BACK;
            }
            else if (nomer == "5")
            {
                return;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Maaf, nomor yang anda inputkan salah");
                Console.ReadLine();
                goto BACK;
            }

        }
        public static void deleteData() {
            BACK:
            SubjectController pSub = new SubjectController();
            StudentController pStu = new StudentController();
            TeacherController pTea = new TeacherController();
            Console.Clear();
            Console.WriteLine("Pilih submenu delete data yang tersedia!");
            Console.WriteLine("1. Delete Data Siswa");
            Console.WriteLine("2. Delete Data Guru");
            Console.WriteLine("3. Delete Data Nilai");
            Console.WriteLine("4. Delete Data Mata Pelajaran ");
            Console.WriteLine("5. Keluar");
            Console.Write("Masukkan nomor submenu: ");
            var nomer = Console.ReadLine();
            if (nomer == "1")
            {
                pStu.delStudent();
                goto BACK;
            }
            else if (nomer == "2")
            {
                pTea.delTeacher();
                goto BACK;
            }
            else if (nomer == "3")
            {
                editData();
                goto BACK;
            }
            else if (nomer == "4")
            {
                pSub.delSubject();
                goto BACK;
            }
            else if (nomer == "5")
            {
                return;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Maaf, nomor yang anda inputkan salah");
                Console.ReadLine();
                goto BACK;
            }
        }
        public static void printReport() {
            BACK:
            StudentController pStu = new StudentController();
            TeacherController pTea = new TeacherController();
            Console.Clear();
            Console.WriteLine("Pilih submenu input data yang tersedia!");
            Console.WriteLine("1. Input Data Siswa");
            Console.WriteLine("2. Input Data Guru");
            Console.WriteLine("3. Input Data Nilai");
            Console.WriteLine("4. Input Data Mata Pelajaran ");
            Console.WriteLine("5. Keluar");
            Console.Write("Masukkan nomor submenu: ");
            var nomer = Console.ReadLine();
            if (nomer == "1")
            {
                pStu.inputStudent();
                goto BACK;
            }
            else if (nomer == "2")
            {
                pTea.inputTeacher();
                goto BACK;
            }
            else if (nomer == "3")
            {
                editData();
                goto BACK;
            }
            else if (nomer == "4")
            {
                deleteData();
                goto BACK;
            }
            else if (nomer == "5")
            {
                return;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Maaf, nomor yang anda inputkan salah");
                Console.ReadLine();
                goto BACK;
            }
        }

    }
}
