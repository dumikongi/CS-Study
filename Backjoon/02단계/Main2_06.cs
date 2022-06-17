using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backjoon._02단계
{
    internal class Main2_06
    {
        static void Main1(string[] args)
        {
            string[] num = Console.ReadLine().Split(' ');
            int n1 = int.Parse(num[0]);
            int n2 = int.Parse(num[1]);

            if (n1 < 0 || n1 > 23) return;
            else if (n2 < 0 || n2 > 60) return;

            Console.WriteLine();

            string t = Console.ReadLine();
            int c = int.Parse(t);

            if (c < 0 || c > 1000) return;

            int b1 = n2 + c;

            if (b1 < 60)
            {
                
                Console.WriteLine(n1 + ' ' + b1 );
            }

            /*
            else
            {
                int b2 = n2 + (c % 60);
                int a1 = n1 + (c / 60);

                if(b2 < 60)
                {
                    Console.WriteLine(n1 + a1 + ' ' + b2);
                }
                
                else
                {
                    Console.WriteLine(n1 + a1 + 1 + ' ' + b2 - 60);

                }
                    
            }
            */



        }
    }
}
