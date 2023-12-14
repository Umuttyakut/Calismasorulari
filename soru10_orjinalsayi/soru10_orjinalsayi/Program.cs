using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soru10_orjinalsayi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int toplam = 0;
            for (int i = 1000; i < 10000; i++)
            {
                toplam = i % 100;
                toplam += i / 100;
                toplam = Convert.ToInt32(Math.Pow(toplam, 2));
                if (i == toplam)
                {
                    Console.WriteLine(i+" ");
                }
                toplam = 0;
            }
            Console.ReadKey();

        }
    }

}


