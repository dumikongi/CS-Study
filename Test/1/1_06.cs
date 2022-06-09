using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._1
{
    internal class _1_06
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("점수 입력 : ");
            int score = int.Parse(Console.ReadLine());
            char grade;

            Console.Write("입력한 점수는 {0}점이고, 등급은 ", score);

            if (score >= 90 && score <= 100)
            {
                grade = 'A';
            }
            else if (score >= 80)
            {
                grade = 'B';
            }
            else if (score >= 70)
            {
                grade = 'C';
            }
            else if (score >= 60)
            {
                grade = 'D';
            }
            else if (score >= 50)
            {
                grade = 'E';
            }
            else
            {
                grade = 'F';
            }

            Console.WriteLine(grade + "입니다.");
        }
    }
}
