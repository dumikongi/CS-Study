using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/**
 * 
 * 날짜 : 2022/06/03
 * 이름 : 허락녕 
 * 내용 : C# 입력 실습하기 교재 p104
 * 
 */

namespace ch02
{
    internal class _4_InputTest
    {
        static void Main1(string[] args)
        {

            //이름입력
            Console.Write("이름:");                 //read 입력
            string name = Console.ReadLine();   //readline 줄 바꾸기


            //나이입력
            Console.WriteLine("나이 : ");
            string age = Console.ReadLine();

            //주소입력
            Console.Write("주소 : ");
            string addr = Console.ReadLine();


            Console.WriteLine("============");
            Console.WriteLine("이름: "+name);
            Console.WriteLine("나이 : "+age);
            Console.WriteLine("주소 : " + addr);
        }
    }
}
