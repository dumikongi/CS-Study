using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backjoon._03단계
{
    internal class Math3_06
    {
        static void Main1(string[] args)
        {
            string num = Console.ReadLine();
            int n = int.Parse(num);

            for (int i = 0; i < n; i++)
            {

                Console.WriteLine(n-i);
            }
        }
    }
}
