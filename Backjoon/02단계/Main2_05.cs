using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backjoon._02단계
{
    internal class Main2_05
    {
        static void Main1(string[] args)
        {

            String[] num = Console.ReadLine().Split(' ');

            int h = int.Parse(num[0]);
            int m = int.Parse(num[1]);

            if (h < 0 || h > 23) return;
             
            else if (m < 0 || m > 23) return;


            if (m <= 59 && m >= 45)
            {
                m = m - 45;
                Console.WriteLine(h);
                Console.Write(m);
            }

            else if ( m >= 0 && m < 45)
            {
                h--;
                m = m + 15;
                Console.WriteLine(h);
                Console.Write(m);
            }



        }
    }
}
