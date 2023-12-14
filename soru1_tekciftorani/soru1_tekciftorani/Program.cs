using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soru1_tekciftorani
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tek = 0, cift = 0;
            for (int i = 0; i < 20; i++)
            {

                Console.Write("Sayı giriniz :");
                int k = Convert.ToInt32(Console.ReadLine());
                if (k % 2 == 0)
                {
                    cift += k;
                }
                else
                {
                    tek += k;
                }

            }
            Console.WriteLine(cift + " 'in " + tek + " 'e oranı =" + ((double)cift / tek));
            Console.ReadKey();
        }
    }
}
