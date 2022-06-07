using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 * 
 * 날짜 : 2022/06/07
 * 이름 : 허락녕
 * 내용 : 메서드 출력전용 매개변수
 * 
 * 출력 매개변수 ref
 * - 변수의 reference (주소)값으로 참조값이 가리키는 실제변수에 값을 대입하는 대입변수
 * 
 * 출력 매개변수 out
 * - 별도의 변수선언 없이 바로 메서드 호출시 메서드의 결과를 리턴받는 매개변수
 * - 메서드는 하나의 리턴값을 여러개 리턴할 수 있는 
 * 
 */

namespace ch04
{
    internal class _5_MethodParameter
    {
        static void Main(string[] args)
        {
            // ref 매개변수 
            int num1 = 10;
            int num2 = 3;
            int num3 = 0;               // 여기에도 밑에처럼 없는 게 더 나은 듯
            int num4 = 0;               // 여기에도 밑에처럼 없는 게 더 나은 듯
            // stack 안에 num1, num2, num3, num4 공간이 만들어짐.

            Divider1(num1, num2, ref num3, ref num4);                   // 참조값은 주소다. 따라서 ref 붙여야 한다.

            Console.WriteLine(" 몫 : {0}, 나머지 : {1}", num3, num4);






            // out 매개변수

            int n1 = 10;
            int n2 = 3;
           

            Divider2(n1, n2, out int n3, out int n4);                        // out을 이용해서 2개를 리턴할 수 있다

            Console.WriteLine(" 몫 : {0}, 나머지 : {1}", n3, n4);
        }



        public static void Divider1(int a, int b, ref int quoutient, ref int remainder)           // qoutient와 remainder는 주솟값이다.
            // stack 안에 a, b 자리 만들어짐 여기에 10과 3이 들어감
        {
            quoutient = a / b;        
            remainder = a % b;
            // stack 안에 q, r 자리 만들어지고 여기에 num3, num4 가 들어감, 계산된 q, r이 num3과 num4 자리에 들어간다
        }

        public static void Divider2(int a, int b, out int quoutient, out int remainder)
        {
            quoutient = a / b;
            remainder = a % b;
        }
    }
}
