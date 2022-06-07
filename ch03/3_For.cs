using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/06/07
 * 이름 : 허락녕
 * 제목 : 반복문 실습하기 교재 P157
 * 
 */

namespace ch03
{
    internal class _3_For  
    {
        static void Main1(string[] args)
        {
            // for문, 반복문(Loop), 조건식의 결과가 참인 동안 반복적으로 실행, for((초기식(변수선언); 조건식; 증감식))
            for (int i = 1; i <=5; i++ )
            {
                Console.WriteLine("{0}회 반복...", i);
            }
                            
            

            // 1부터 10까지 합
            int sum = 0;

            for (int k = 1; k <= 10; k++)
            {
                sum += k;                                          //sum = sum + k; ,  시그마와 같은 역할
            }

            Console.WriteLine("1부터 10까지의 합 : " +sum);
            

            // 1부터 10까지의 짝수합
            int tot = 0;

            for (int l = 0; l <= 10; l++)
            {
                if( l % 2 == 0 )                                  // 배수는 %를 이용하여 나머지로 판별한다
                {
                    tot += l;
                }
            }

            Console.WriteLine("1부터 10까지의 짝수합 : " +tot);

            // 중첩 for문, 아래에서 진행되는 흐름들을 스레드(Thread)라고 한다
            for (int a = 1; a <= 3; a++) 
            {
                Console.WriteLine("a: "+a);

                for ( int b = 1; b<= 4; b++)
                {
                    Console.WriteLine("b: " +b);
                    for ( int c =1; c <= 5; c++) 
                    {
                        Console.WriteLine("c: "+c);
                    }
                }
            }
            
            // 구구단
            for (int x =2; x <=9; x++)
            {
                Console.WriteLine("{0}단 시작", x);
                for (int y = 1; y <= 9; y++)
                {
                    int z = x * y;
                    Console.WriteLine("{0} x {1} = {2}", x, y, z);             // " " : 문자열안의 { }는 순서대로 뒤에 주어진 문자가 들어간다
                }
            }



// 삼각형 또는 역삼각형
for (int start = 1; start <= 10; start++)                                   //for(int start 10; start >= 1; start--)
{
    for (int end = 10; end >= start; end--)                                 // for (int end = 1; end <= start; end++)
    {
        Console.Write("★");
    }
    Console.WriteLine();                                    //줄바꿈
}

            














           

            
            
        }
    }

}



