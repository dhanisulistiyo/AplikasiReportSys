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
          
            StudentController intr = new StudentController();
            BACK:
            Console.Clear();
            Console.WriteLine("=====================================");
            Console.WriteLine("==Aplikasi HR SMKN 1 Cikarang Barat==");
            Console.WriteLine("=====================================");
            Console.WriteLine("Pilih menu yang tersedia!");
            Console.WriteLine("1. Input Data");
            Console.WriteLine("2. Lihat Data");
            Console.WriteLine("3. Edit Data");
            Console.WriteLine("4. Hapus Data");
            Console.WriteLine("5. Cetak Raport");
            Console.WriteLine("6. Keluar");
            Console.Write("Masukkan nomer: ");
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
                Console.WriteLine("Input Salah");
                Console.ReadLine();
                goto BACK;
            }
        }

        public static void inputData() {
            BACK:
            StudentController pStu = new StudentController();
            Console.Clear();
            Console.WriteLine("Pilih submenu input data yang tersedia!");
            Console.WriteLine("1. Input Data Siswa");
            Console.WriteLine("2. Input Data Guru");
            Console.WriteLine("3. Input Data Nilai");
            Console.WriteLine("4. Input Data Mata Pelajaran ");
            Console.WriteLine("5. Keluar");
            Console.Write("Masukkan nomer: ");
            var nomer = Console.ReadLine();
            if (nomer == "1")
            {
                pStu.inputStudent();
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
            else if (nomer == "5")
            {
                return;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Input Salah");
                Console.ReadLine();
                goto BACK;
            }
        }
        public static void viewData() {
            BACK:
            StudentController pStu = new StudentController();
            Console.Clear();
            Console.WriteLine("Pilih submenu lihat data yang tersedia!");
            Console.WriteLine("1. Lihat Data Siswa");
            Console.WriteLine("2. Lihat Data Guru");
            Console.WriteLine("3. Lihat Data Nilai");
            Console.WriteLine("4. Lihat Data Mata Pelajaran ");
            Console.WriteLine("5. Keluar");
            Console.Write("Masukkan nomer: ");
            var nomer = Console.ReadLine();
            if (nomer == "1")
            {
                pStu.printStudent();
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
            else if (nomer == "5")
            {
                return;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Input Salah");
                Console.ReadLine();
                goto BACK;
            }
        }
        public static void editData() {
            BACK:
            StudentController pStu = new StudentController();
            Console.Clear();
            Console.WriteLine("Pilih submenu edit data yang tersedia!");
            Console.WriteLine("1. Edit Data Siswa");
            Console.WriteLine("2. Edit Data Guru");
            Console.WriteLine("3. Edit Data Nilai");
            Console.WriteLine("4. Edit Data Mata Pelajaran ");
            Console.WriteLine("5. Keluar");
            Console.Write("Masukkan nomer: ");
            var nomer = Console.ReadLine();
            if (nomer == "1")
            {
                pStu.editStudent();
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
            else if (nomer == "5")
            {
                return;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Input Salah");
                Console.ReadLine();
                goto BACK;
            }

        }
        public static void deleteData() {
            BACK:
            StudentController pStu = new StudentController();
            Console.Clear();
            Console.WriteLine("Pilih submenu delete data yang tersedia!");
            Console.WriteLine("1. Delete Data Siswa");
            Console.WriteLine("2. Delete Data Guru");
            Console.WriteLine("3. Delete Data Nilai");
            Console.WriteLine("4. Delete Data Mata Pelajaran ");
            Console.WriteLine("5. Keluar");
            Console.Write("Masukkan nomer: ");
            var nomer = Console.ReadLine();
            if (nomer == "1")
            {
                pStu.delStudent();
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
            else if (nomer == "5")
            {
                return;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Input Salah");
                Console.ReadLine();
                goto BACK;
            }
        }
        public static void printReport() {
            BACK:
            StudentController pStu = new StudentController();
            Console.Clear();
            Console.WriteLine("Pilih submenu input data yang tersedia!");
            Console.WriteLine("1. Input Data Siswa");
            Console.WriteLine("2. Input Data Guru");
            Console.WriteLine("3. Input Data Nilai");
            Console.WriteLine("4. Input Data Mata Pelajaran ");
            Console.WriteLine("5. Keluar");
            Console.Write("Masukkan nomer: ");
            var nomer = Console.ReadLine();
            if (nomer == "1")
            {
                pStu.inputStudent();
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
            else if (nomer == "5")
            {
                return;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Input Salah");
                Console.ReadLine();
                goto BACK;
            }
        }




    }
}
