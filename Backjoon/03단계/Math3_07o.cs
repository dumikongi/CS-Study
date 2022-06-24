using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backjoon._03단계
{
    internal class Math3_07o
    {
        static void Main1(string[] args)
        {
            int t = int.Parse(Console.ReadLine());

            int[] a = new int[t];
            int[] b = new int[t];

            StringBuilder st = new StringBuilder();


            for(int i = 0; i < t; i++)
            {
                string[] ab = Console.ReadLine().Split(' ');

                a[i] = int.Parse(ab[0]);
                b[i] = int.Parse(ab[1]);

                if (a[i] < 1 || a[i] > 9 || b[i] < 1 || b[i] > 9) return;

                st.Append("Case #" + (i+1) + ":" + a[i] + b[i] + "\n");
            }

                       
                Console.WriteLine(st.ToString());
            
            


        }
    }
}
