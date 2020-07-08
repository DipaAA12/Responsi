using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectMahasiswa
{
    class Program
    {
        // deklarasi objek collection untuk menampung objek mahasiswa
        static List<Mahasiswa> daftarMahasiswa = new List<Mahasiswa>();

        static void Main(string[] args)
        {
            Console.Title = "Responsi UAS Matakuliah Pemrograman";

            while (true)
            {
                TampilMenu();

                Console.Write("\nNomor Menu [1..4]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahMahasiswa();
                        break;

                    case 2:
                        HapusMahasiswa();
                        break;

                    case 3:
                        TampilMahasiswa();
                        break;

                    case 4: // keluar dari program
                        return;

                    default:
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menampilkan menu
            Console.WriteLine("Pilih Menu:");
            Console.WriteLine("1. Tambah Mahasiswa \n2. Hapus Mahasiswa \n3. Tampil Mahasiswa \n4. Keluar");
        }

        static void TambahMahasiswa()
        {
            Mahasiswa mahasiswa = new Mahasiswa();

            Console.Clear();

            Console.WriteLine("Tambah Mahasiswa: ");

            Console.Write("NIM: ");
            mahasiswa.Nim = Console.ReadLine();

            Console.Write("Nama: ");
            mahasiswa.Nama = Console.ReadLine();

            Console.Write("Jenis Kelamin [L/P]: ");
            string jenis = Console.ReadLine();

            Console.Write("IPK: ");
            mahasiswa.Ipk = Console.ReadLine();

            mahasiswa.JenisKelamin = (jenis == "L" || jenis == "P") ? "Laki-laki" : "Perempuan";

            daftarMahasiswa.Add(mahasiswa);

            // PERINTAH: lengkapi kode untuk menambahkan objek mahasiswa ke dalam collection

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void HapusMahasiswa()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menghapus objek mahasiswa dari dalam collection
            Console.WriteLine("Hapus Data Mahasiswa");

            bool found = true;

            string NIM;
            Console.Write("NIM  :");
            NIM = Console.ReadLine();

            for (int i = 0; i < daftarMahasiswa.Count; i++)
            {
                if (NIM == daftarMahasiswa[i].Nim)
                {
                    daftarMahasiswa.Remove(daftarMahasiswa[i]);
                    found = true;
                    break;
                }
                else
                {
                    found = false;
                }
            }
            if (!found)
            {
                Console.WriteLine("NIM tidak ditemukan");
            }
            else
            {
                Console.WriteLine("Data Mahasiswa Telah Berhasil Di Hapus");
            }

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilMahasiswa()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menampilkan daftar mahasiswa yang ada di dalam collection

            Console.WriteLine("Data Mahasiswa");

            if (daftarMahasiswa.Count > 0)
            {
                for (int i = 0; i < daftarMahasiswa.Count; i++)
                {
                    Console.WriteLine("{0}. | {1}, {2}, {3}, {4}", i + 1, daftarMahasiswa[i].Nim, daftarMahasiswa[i].Nama, daftarMahasiswa[i].JenisKelamin, daftarMahasiswa[i].Ipk);
                }
            }
            else
            {
                Console.WriteLine(" Tidak Ada Daftar Mahasiswa");
            }

            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}
