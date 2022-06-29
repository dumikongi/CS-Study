using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backjoon._04단계
{
    internal class _07
    {
        static void Main1(string[] args)
        {

            int c = int.Parse(Console.ReadLine());
            while (c > 0)
            {
                c--;
                string[] s = Console.ReadLine().Split();
                int sum = 0;
                for (int i = 1; i < s.Length; i++)
                {
                    sum += int.Parse(s[i]);
                }
                int average = sum / int.Parse(s[0]);
                int result = 0;
                for (int i = 1; i < s.Length; i++)
                {
                    if (int.Parse(s[i]) > average)
                    {
                        result++;
                    }
                }
                Console.WriteLine($"{(float)result / float.Parse(s[0]) * 100:0.000}%");
            } // 평균은 넘겠지
        }
    }
}
