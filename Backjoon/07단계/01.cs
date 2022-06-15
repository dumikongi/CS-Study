using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backjoon._07단계
{
    internal class _1
    {
        static void Main1(string[] args)
        {
            string[] num = Console.ReadLine().Split();
            int n1 = int.Parse(num[0]);   // 고정비용
            int n2 = int.Parse(num[1]);   // 가변비용
            int n3 = int.Parse(num[2]);   // 하나당 가격
            
           for (int i = 1; i*n3 <= n1 + n2 *i; i++)
            {
                if (false)
                {
                    Console.WriteLine(i);
                }
            }
                
            

        }
    }
}
