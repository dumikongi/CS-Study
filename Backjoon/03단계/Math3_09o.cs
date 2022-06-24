using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backjoon._03단계
{
    internal class Math3_09o
    {
        static void Main1(string[] args)
        {
            string num = Console.ReadLine();
            int n = int.Parse(num);
            

            for (int i = 1; i <= n; i++)
            {
                for(int j = 0; j < i; j++)
                Console.Write("*");

                Console.WriteLine();
            }

           

        }




    }
}
