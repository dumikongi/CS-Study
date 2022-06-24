using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backjoon._03단계
{
    internal class Main3_01o
    {
        static void Main1(string[] args)
        {
            string num = Console.ReadLine();
            int n = int.Parse(num);

            for(int j = 1; j < 10; j++)
            {
                int multi;
                multi = n*j;
               
                Console.WriteLine(n+" * "+ j +" = " +multi);
            }

        }
    }
}
