using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectPenjualan
{
    class Program
    {
        // deklarasi objek collection untuk menampung objek penjualan
        static List<Penjualan> daftarPenjualan = new List<Penjualan>();

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
                        TambahPenjualan();
                        break;

                    case 2:
                        HapusPenjualan();
                        break;

                    case 3:
                        TampilPenjualan();
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
			Console.Clear();
			Console.WriteLine("Pilih Menu");
			Console.WriteLine("1. Tambah Pemjualan");
			Console.WriteLine("2. Hapus Penjualan");
			Console.WriteLine("3. Tampil Penjualan");
			Console.WriteLine("4. Keluar");
        }

        static void TambahPenjualan()
        {
			Penjualan penjualan = new Penjualan();
			
            Console.Clear();
			Console.WriteLine("Tambah Penjualan: ");

            Console.Write("Nota: ");
            penjualan.Nota = Convert.ToInt32(Console.ReadLine());

            Console.Write("Tanggal: ");
            penjualan.Tanggal = Console.ReadLine();

            Console.Write("Customer: ");
            penjualan.Customer = Console.ReadLine();

            Console.Write("Jenis [T/K]: ");
            string jenis = Console.ReadLine();

            penjualan.Jenis = (jenis == "T" || jenis == "t") ? "Tunai" : "Kredit";

            Console.Write("Total Nota: ");
            penjualan.TotalNota = Convert.ToInt32(Console.ReadLine());

            daftarPenjualan.Add(penjualan);

            // PERINTAH: lengkapi kode untuk menambahkan penjualan ke dalam collection

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void HapusPenjualan()
        {
            Console.Clear();
			bool status = false;
            // PERINTAH: lengkapi kode untuk menghapus penjualan dari dalam collection

			Console.WriteLine("Hapus Data Penjualan");
            Console.Write("Nota: ");
            int nota = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < daftarPenjualan.Count; i++)
            {
             if (nota == daftarPenjualan[i].Nota)
              {
               daftarPenjualan.Remove(daftarPenjualan[i]);
               status = true;
               break;
              } else
              {
               status = false;
              }
            }

            if (status)
            {
            Console.WriteLine("Data Penjualan dengan Nota \"{0}\" telah dihapus", nota);
            } else
            {
            Console.WriteLine("Data Penjualan dengan Nota \"{0}\" tidak ditemukan", nota);
            }
            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilPenjualan()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menampilkan daftar penjualan yang ada di dalam collection
			Console.WriteLine("Tampil Penjualan: ");

            if (daftarPenjualan.Count > 0)
            {
              for (int i = 0; i < daftarPenjualan.Count; i++)
               {
                Console.WriteLine(" {0}. | {1}, {2}, {3}, {4}, {5}", i + 1, daftarPenjualan[i].Nota, daftarPenjualan[i].Tanggal, daftarPenjualan[i].Customer, daftarPenjualan[i].Jenis, daftarPenjualan[i].TotalNota);
               }
            } else
            {
            Console.WriteLine("- Tidak Ada Daftar Penjualan");
            }
            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}
