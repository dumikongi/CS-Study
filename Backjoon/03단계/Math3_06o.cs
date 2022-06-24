using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backjoon._03단계
{
    internal class Math3_06o
    {
        static void Main1(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            StringBuilder allNumbers = new StringBuilder();

            if (n < 1 || n > 100000) return;

            for (int i = 0; i < n; i++)
            {
                int number = n - i;
                allNumbers.Append(number + "\n");
                Console.WriteLine(allNumbers.ToString());
            }
        }
    }
}
