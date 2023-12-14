using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soru4_decimaltobinary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi1, kalan;
            string yazikalan = "";
            Console.Write("Sayı giriniz :");
            sayi1 = Convert.ToInt32(Console.ReadLine());
            while (sayi1 != 0)
            {
                kalan = sayi1 % 2;
                sayi1 = sayi1 / 2;

                yazikalan = kalan.ToString() + yazikalan;
            }
            Console.WriteLine("2'lik Sistemde Karşılığı :" + yazikalan);

            Console.ReadKey();
        }
    }
}
