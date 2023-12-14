using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soru6_basamakhesaplama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Sayı giriniz :");
            int bassayi = 0;
            int d = Convert.ToInt16(Console.ReadLine());
            while (d != 0)
            {
                d = d / 10;
                bassayi++;
            }
            Console.WriteLine("basamak sayısı :" + bassayi);
            Console.ReadKey();
        }
    }
}
