using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mukemmelsayilar
{
    internal class Program
    {
        public static void mukemmelsayi(int sayi)
        {
            int toplam = 0;
            if (sayi % 2 == 0)
            {
                for (int i = 1; i < sayi; i++)
                {
                    if (sayi % i == 0)
                    {
                        toplam += i;
                    }
                }
                if (toplam == sayi)
                {
                    Console.WriteLine(sayi + " bir mükemmel sayıdır");
                }
                else
                {
                    Console.WriteLine(sayi + " bir mükemmel sayı değildir");
                }
            }
            else
            {
                Console.WriteLine("tek sayı girdiniz");
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Sayı giriniz :");
            int p = Convert.ToInt16(Console.ReadLine());
            mukemmelsayi(p);
            Console.ReadKey();
        }
    }
}
