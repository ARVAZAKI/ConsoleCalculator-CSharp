
using System.Globalization;

namespace CalculatorConsole
{
    class program
    {
        static void Main(string[] args)
        {
            double total;
            Console.WriteLine("---- Console Calclator by @vazakii ----");
            Console.WriteLine("======================================");
            Console.WriteLine("note : Metode : perkalian/pembagian/penjumlahan/pengurangan/hasil bagi");
            Console.WriteLine("======================================");

            Console.Write("Masukkan angka pertama : ");
            string a = Console.ReadLine();

            Console.Write("Masukkan angka kedua : ");
            string b = Console.ReadLine();

            Console.Write("Metode : ");
            string method = Console.ReadLine();

            switch (method)
            {
                case "perkalian":
                    total = Convert.ToDouble(a) * Convert.ToDouble(b);
                    Console.WriteLine("Hasil = {0}",total);
                    break;
                case "pembagian":
                    total = Convert.ToDouble(a) / Convert.ToDouble(b);
                    Console.WriteLine("Hasil = {0}", total);
                    break;
                case "penjumlahan":
                    total = Convert.ToDouble(a) + Convert.ToDouble(b);
                    Console.WriteLine("Hasil = {0}", total);
                    break;
                case "pengurangan":
                    total = Convert.ToDouble(a) - Convert.ToDouble(b);
                    Console.WriteLine("Hasil = {0}", total);
                    break;
                case "hasil bagi":
                    total = Convert.ToDouble(a) % Convert.ToDouble(b);
                    Console.WriteLine("Hasil = {0}", total);
                    break;
            }
            Console.WriteLine("======================================");
            Console.WriteLine("---- THANKS YOU <3 ----");
            Console.WriteLine("======================================");





            Console.ReadLine();
        }
    }
}