using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book.Ch06
{

    class Fibonacci2
    {
        private static Dictionary<int, long> memo = new Dictionary<int, long>();
        public static long Get(int i)
        {
            // 기본값
            if (i < 0) { return 0; }
            if (i == 1) { return 1; }
          
            // 이미 계산했던 값인지 확인
            if (memo.ContainsKey(i))
            {
                return memo[i];
            }

            else
            {    // 계산하지 않았다면
                long value = Get(i - 1) + Get(i - 2);
                memo[i] = value;
                return value;
            }           
        }
    }

    internal class p309
    {
        static void Main1(string[] args)
        {
            Console.WriteLine(Fibonacci2.Get(40));
        }
    }
}
