using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backjoon._02단계
{
    internal class Main2_02999
    {
        static void Main1(string[] args)
        {
            string num = Console.ReadLine();
            int n = int.Parse(num);

            if (n >= 90)
            {
                Console.WriteLine("A");
            }

            else if (n >= 80)
            {
                Console.WriteLine("B");
            }

            else if (n >= 70)
            {
                Console.WriteLine("C");
            }
            else if (n >= 60)
            {
                Console.WriteLine("D");
            }
            else
            {
                Console.WriteLine("F");
            }
                
        }
    }
}
