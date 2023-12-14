using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soru8_1_ile_500_arası_toplam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int f = 0;
            for (int i = 0; i < 500; i++)
            {
                f += i;
            }
            Console.WriteLine(f);
            Console.ReadKey();
        }
    }
}
