using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soru9_sayitahmin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int e = 6, randsayi = 0, tahmin = 0;
            Random rnd = new Random();
            randsayi = rnd.Next(10);
            while (e > 0)
            {
                Console.Write("Sayıyı bulunuz :");
                tahmin = Convert.ToInt16(Console.ReadLine());
                if (tahmin > randsayi)
                {
                    e--;
                    Console.WriteLine("Daha küçük bir değer girin " + e + " hakkınız kaldı");
                }
                else if (tahmin < randsayi)
                {
                    e--;
                    Console.WriteLine("Daha büyük bir değer girin " + e + " hakkınız kaldı");
                }
                if (randsayi == tahmin)
                {
                    Console.WriteLine("Tebrikler doğru tahmin");
                    Console.ReadKey();
                }
                else
                {
                    
                    if (e == 0)
                    {
                        Console.WriteLine("Hakkınız bitmiştir. Sayımız :" + randsayi);
                        Console.ReadKey();
                    }
                }
            }
        }
    }
}
