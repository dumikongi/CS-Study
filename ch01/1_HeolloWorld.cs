using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/06/02
 * 이름 : 허락녕
 * 내용 : C# 개발환경 설정 및 Hello World 출력 p44 
 */
namespace ch01
{
    internal class _1_HeolloWorld
    {
        static void Main(string[] args)
        {
            // 기본출력
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello c#!");

            //서식출력
            Console.Write("Helllo\t");
            Console.Write("Korea\n");

            // 포맷출력
            Console.WriteLine("{0}, {1}", "Hello", "Busan");
           
        }
    }
}
