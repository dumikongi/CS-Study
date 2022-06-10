using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backjoon._03단계
{
    internal class Math3_03
    {
        static void Main1(string[] args)
        {
            string num = Console.ReadLine();

            long n = long.Parse(num);
            long output = 0;

            for(int j = 0; j <= n; j++)
            {
                output += j;
            }

            Console.WriteLine(output);
        }

        
    }
}
