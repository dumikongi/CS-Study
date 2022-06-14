using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backjoon._03단계
{
    internal class Math3_10
    {

        static void Main1(string[] args)
        {
            string num = Console.ReadLine();
            int n = int.Parse(num);

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n - 1; j++)
                {
                    Console.Write(' ');
                }

                for (int k = 5; k > 5 - i; k--)
                {
                    Console.Write('*');
                }

                Console.WriteLine();



            }
        }
    }
}
