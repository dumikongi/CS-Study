using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book.ch03
{
    internal class p143
    {
        static void Main1A(string[] args)
        {
            Console.Write("정수를 쓰시오 : ");
            int number = int.Parse(Console.ReadLine());
            

            Console.WriteLine(number > 0 ? "자연수입니다." : "자연수가 아닙니다.");
        }
    }
}
