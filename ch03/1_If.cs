using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 
 * 날짜 : 2022/06/03
 * 이름 : 허락녕
 * 내용 : 조건문 실습 교재 p127
 * 
 */


namespace ch03
{
    internal class _1_If
    {
        static void Main1(string[] args)
        {
            //If
            int num1 = 1;
            int num2 = 2;

            if (num1 < num2)
            {
                //참이면 실행
                Console.WriteLine("num1은 num2보다 작다");
            }



            if (num1 > num2)
            {
                Console.WriteLine("num1은 num2보다 작지 않다");
                //거짓이면 실행되지 않는다
            }



             if (num1 > 0)
            {
                if(num2>1)
                {
                    Console.WriteLine("num1은 0보다 크고 num2는 1보다 크다");
                }
            }
               

            if ( num1 > 3 || num2 > 1)
            {
                Console.WriteLine("num1은 0보다 크고 num2는 1보다 크다");
            }





            //If ~else

            int var1 = 1, var2 = 2;

            if (var1 < var2)
            {
                //조건이 참이면 실행
                Console.WriteLine("var1이 var2보다 작다");
            }
            else
            {
                //조건이 거짓이면 실행
                Console.WriteLine("var1이 var2보다 작지 않다");
            }




            //If ~else If ~else
            int n1 = 10, n2 = 20, n3 = 30, n4 = 40;


            if (n1 > n2)                              //조건1
            {
                Console.WriteLine("n1이 n2보다 크다");
            }
            else if (n2 > n3)                         //조건2
            {
                Console.WriteLine("n2이 n3보다 크다");

            }
            else if (n3 > n4)                         //조건3
            {
                Console.WriteLine("n3이 n4보다 크다");

            }
            else
            {
                Console.WriteLine("n4가 가장 크다");
            }






        }
    }
}
