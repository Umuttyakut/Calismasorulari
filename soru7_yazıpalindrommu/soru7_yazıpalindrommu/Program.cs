using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soru7_yazıpalindrommu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bir kelime girin :");
            string kelime = Console.ReadLine();
            char[] normal = kelime.ToArray();
            char[] ters = kelime.ToArray();
            Array.Reverse(ters);
            bool pdom = true;
            for (int i = 0; i < kelime.ToArray().Count(); i++)
            {
                if (normal[i] != ters[i])
                {
                    pdom = false;
                }
            }
            Console.WriteLine("Palindrom mu :" + pdom);
            Console.ReadKey();
        }
    }
}
