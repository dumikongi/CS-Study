using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 * 날짜 : 2022/066/07
 * 이름 : 허락녕
 * 내용 : 매서드 실습하기 교재 p265
 * 
 */

// 일련의 코드 로직을 모듈화한 구조체
// 함수를 객체지향 프로그램에서는 매서드라고 부른다.
// 매서드는 정의하고 호출한다.


namespace ch04
{
    internal class _1_Method
    {
        static void Main1(string[] args)          // 메인 메서드 시작, static이 선언한 매서드만 불러올 수 있으므로 아래의 Public에서 static int f로 해야한다.
        {
            //매서드 호출 1
            int r1 = f(1);
            int r2 = f(8);
            int r3 = f(3);

            Console.WriteLine("r1 = "+r1);
            Console.WriteLine("r2 = "+r2);
            Console.WriteLine("r3 = "+r3);
        }                                       // 메인 메서드 끝


        // 매서드 호출 2
        int t1 = Sum(1, 10);
        int t2 = Sum(1, 100);
        int t3 = Sum(start: 1, end: 1000);

        //Console.WriteLine("t1 = "+t1);
        //Console.WriteLine("t2 = "+t2);
        //Console.WriteLine("t3 = "+t3);


        // 매서드 정의 1 -> 매서드 호출은 위의 Main에서 한다.
        public static int f(int x)                     // 메서드 앞에는 public이 온다고 우선 생각하라    f는 함수 이름   int x는 매개변수   //f(x)에 int만 붙었다. 왜 정수니깐
        {
            int y = 2 * x + 3;
            return y;
        }


        // 매서드 정의 2
        public static int Sum(int start, int end)            // 매서드는 대문자로 시작
        {
            int total = 0;
            for( int k = start; k <= end; k++)
            {
                total+= k;
            }

            return total;
        }


        
       
    }

}
