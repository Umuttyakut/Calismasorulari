using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soru3_kelimetersyaz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kelime girin :");
            string metin = Console.ReadLine();
            for (int i = metin.Length - 1; i >= 0; i--)
            {
                char c = metin[i];
                Console.Write(c);
            }
            Console.ReadKey();
        }
    }
}
