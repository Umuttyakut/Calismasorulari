using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soru5_fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int a = 0, b = 1, temp = 0;
            for (int i = 0; i < x; i++)
            {
                Console.Write(a + " ");
                temp = a + b;
                a = b;
                b = temp;
            }
            Console.ReadKey();
        }
    }
}
