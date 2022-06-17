using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backjoon._09단계
{
    internal class _09_03
    {
        static void Main1(string[] args)
        {
            string num = Console.ReadLine();
            int n = int.Parse(num);
            Console.WriteLine(fibonacci(n));
        }

       static int fibonacci(int n)      // 재귀함수에서는 앞에 못 쓰는건가..
        { 
            if (n <= 1)
            {
                return n;
            }
            return fibonacci(n-2) + fibonacci(n - 1);
        }
    }
}
