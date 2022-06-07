using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 * 날짜 : 2022/06/07
 * 이름 : 허락녕
 * 내용 : 메서드 스탯 실습하기 
 * 
 */

namespace ch04
{
    internal class _4_MethodTab                               // 자료가 들어가는 거는 push, 나오는 것은 pop
    {
        static void Main1(string[] args)
        {
            int result = 0;
            int n1 = 1;
            int n2 = 10;

            result = Sum(n1, n2);

            Console.WriteLine("result : "+ result);

        }


        public static int Sum(int start, int end)
        {
            int total = 0;

            for (int k = start; k <= end; k++)
            {
                total += k;
            }
            return total;
        }
    }
}
