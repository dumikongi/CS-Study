using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 * 날짜 : 2022/06/03
 * 이름 : 허락녕
 * 내용 : 조건문 Switch 실습 교재 p127
 * 
 * 
 */

namespace ch03
{
    internal class _2_Switch
    {
        static void Main(string[] args)
        {
            Console.Write("점수입력 : ");                  
            string strscore = Console.ReadLine();         // 콘솔은 문자열이다

            int score = int.Parse(strscore);              // 문자열을 숫자로 변환함.
            int grade = score / 10;                       

            switch (grade)
            {
                case 10:
                    Console.WriteLine("S입니다.");
                    break;
                case 9:
                    Console.WriteLine("A입니다.");
                    break;
                case 8:
                    Console.WriteLine("B입니다.");
                    break ;
                case 7:
                    Console.WriteLine("C입니다.");
                    break;  
                case 6:
                    Console.WriteLine("D입니다.");
                    break;
                default:
                    Console.WriteLine("F입니다.");
                    break;

            }
        }
    }
}
