using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 * 날짜 : 2022/06/02
 * 이름 : 허락녕
 * 내용 : 연산자(Operator) 실습하기 교재 p90
 * 
 * 연산자(Operator)
 * - 변수에 저장된 데이터의 처리를 위해 연산자를 사용
 * - 연산자는 크게 산술, 증가감소, 복합대입, 비교, 논리연산자 등이 있다.
 * 
 * 
 * 
 */

namespace ch02
{
    internal class _3_Operator
    {
        static void Main(string[] args)
        {
            //산술연산자
            int num1 = 1;
            int num2 = 2;
            int num3 = 3;
            int num4 = 4;

            int r1 = num1 + num2;
            int r2 = num1 - num2;
            int r3 = num2 * num3;
            int r4 = num4 / num2;
            int r5 = num4 % num3;

            Console.WriteLine("r1 : "+r1);
            Console.WriteLine("r2 : "+r2);
            Console.WriteLine("r3 : "+r3);
            Console.WriteLine("r4 : "+r4);
            Console.WriteLine("r5 : "+r5);


            //증가감소연산자


            int num = 0;

            num++;
            ++num;

            Console.WriteLine($"num : {num}");  // 문자열 보간 출력


            num--;
            --num;

            Console.WriteLine($"num : {num}");

            //복합대입연산자

            int n1 = 1, n2 = 2, n3 = 3, n4 = 4;

            n1 += 1; //n1 = n1 + 1
            n2 -= 2; //n2 = n2 - 2
            n3 *= 3; //n3 = n3 * 3
            n4 /= 4; //n1 = n4 / 4


            Console.WriteLine($"n1 : {n1}");
            Console.WriteLine($"n2 : {n2}");
            Console.WriteLine($"n3 : {n3}");
            Console.WriteLine($"n4 : {n4}");



            //비교연산자

            int var1 = 1;
            int var2 = 2;

            bool rs1 = var1 > var2;      //var1보다 var2 크다
            bool rs2 = var1 < var2;
            bool rs3 = var1 >= var2;
            bool rs4 = var1 <= var2;
            bool rs5 = var1 == var2;
            bool rs6 = var1 != var2;    // var1과 var2는 다르다 참이므로 rs6 = true

            Console.WriteLine("rs1 : "+rs1);
            Console.WriteLine("rs2 : "+rs2);
            Console.WriteLine("rs3 : "+rs3);
            Console.WriteLine("rs4 : "+rs4);
            Console.WriteLine("rs5 : "+rs5);
            Console.WriteLine("rs6 : "+rs6);   //rs6을 콘솔에 적는데 rs6의 값을 넣어라



            //논리연산자

          

            bool res1 = var1 > 1 && var2 > 2;   // && : and 연산자
            bool res2 = var1 > 0 && var2 > 1;   // 참은 1, 거짓은 0
            bool res3 = var1 > 1 || var2 > 2;   // || : or 연산자
            bool res4 = var1 > 0 || var2 > 1;   // bool 참인지 거짓인지 res4에 대입하라
            bool res5 = !(var1 > var2);         // =! 그 뒤의 식이 참이 아니다



            Console.WriteLine("res1 : "+res1);
            Console.WriteLine("res2 : "+res2);
            Console.WriteLine("res3 : "+res3);
            Console.WriteLine("res4 : "+res4);
            Console.WriteLine("res5 : "+res5);



            //조건연산자

            int a = 1;

            string result = (a > 1) ? "a는 1보다 크다":"a는 1보다 크지 않다" ;    
            // 참이면 앞, 거짓이면 뒤가 result에 대입된다

            Console.WriteLine("result : "+result);

        }
    }
}
