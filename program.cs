using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProjectMahasiswa;

namespace ProjectMahasiswa
{
    class Program
    {
        // deklarasi objek collection untuk menampung objek mahasiswa
        static List<Mahasiswa> daftarMahasiswa = new List<Mahasiswa>();
        Mahasiswa mhs = new Mahasiswa();

        static void Main(string[] args)
        {
            Console.Title = "Responsi UAS Matakuliah Pemrograman";

            while (true)
            {
                TampilMenu();

                Console.Write("\nNomor Menu [1..3]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahMahasiswa();
                        break;

                    case 2:
                        TampilMahasiswa();
                        break;

                    case 3: // keluar dari program
                        return;

                    default:
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.Clear();
            Console.WriteLine("Data Mahasiswa\n");
            Console.WriteLine("1. Tambah Mahasiswa");
            Console.WriteLine("2. Tampil Mahasiswa");
            Console.WriteLine("3. Keluar");


            // PERINTAH: lengkapi kode untuk menampilkan menu
        }

        static void TambahMahasiswa()
        {
            Console.Clear();


            // PERINTAH: lengkapi kode untuk menambahkan objek mahasiswa ke dalam collection
            Mahasiswa mhs = new Mahasiswa();
            Console.Write("NIM: ");
            int Nim = Console.Read();
            Nim = mhs.NIM;

            Console.WriteLine("Nama: ");
            string nama = Console.ReadLine();
            nama = mhs.Nama;

            Console.WriteLine("Jenis Kelamin [L/P]: ");
            string jeniskelamin = Console.ReadLine();
            jeniskelamin = mhs.jenisKelamin;

            if(jeniskelamin == "P")
            {
                jeniskelamin = "Perempuan";
            } 
            else if (jeniskelamin == "L")
            {
                jeniskelamin = "Laki-Laki";
            } 
            else
            {
                jeniskelamin = "Inputan yang anda masukan salah!";
            }

            Console.WriteLine("Ipk: ");
            double IPK = Console.Read();
            IPK = mhs.Ipk;

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilMahasiswa()
        {
            Console.Clear();
            // PERINTAH: lengkapi kode untuk menampilkan daftar mahasiswa yang ada di dalam collection
            for (int i = 0; i < daftarMahasiswa.Count; i++)
            {
                Mahasiswa mhs = daftarMahasiswa[i];

                Console.WriteLine("NIM {0}", mhs.NIM);

                Console.WriteLine("Nama {0}", mhs.Nama);

                Console.WriteLine("Jenis Kelamin {0}", mhs.jenisKelamin);

                Console.WriteLine("IPK {0}", mhs.Ipk);
            }


            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}
