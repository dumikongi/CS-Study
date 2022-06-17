using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backjoon._09단계
{
    internal class _09_01
    {
        static void Main1(string[] args)
        {
            string num = Console.ReadLine();
            int n = int.Parse(num);
            Console.WriteLine(factorial(n));
        }

         static int factorial(int n)          // 이 앞에 private이나 public이 붙으면 틀린다. 왜??
        {
            if (n <= 1)
            {
                return 1;
            }
            return n * factorial(n - 1);
        }
    }
}
