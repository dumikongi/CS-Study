using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backjoon._04단계
{
    internal class _06
    {
        static void Main1(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            int combo = 0;
            int score = 0;
            for (int i = 0; i < t; i++)
            {
                string s = Console.ReadLine();
                for (int j = 0; j < s.Length; j++)
                {
                    if (s[j] == 'O')
                    {
                        ++combo;
                        score += combo;
                    }
                    else
                    {
                        combo = 0;
                    }
                }
                Console.WriteLine(score);
                combo = 0;
                score = 0;
            } // O,X퀴즈
        }
    }
}
