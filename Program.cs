using System;

namespace AdIns
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pilih Soal:");
            Console.WriteLine("1. Soal 3: Fibonacci Sequence");
            Console.WriteLine("2. Soal 4: Pola Bintang");
            Console.WriteLine("3. Soal 5: Format Nomor");
            Console.Write("Masukkan nomor soal yang ingin dijalankan: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Soal3.Run();
                    break;
                case 2:
                    Soal4.Run();
                    break;
                case 3:
                    Soal5.Run();
                    break;
                default:
                    Console.WriteLine("Pilihan tidak valid.");
                    break;
            }
        }
    }
}
