using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 * 날짝 : 2022/06/07
 * 이름 : 허락녕
 * 내용 : 반복문 While 실습하기 교재 p162
 * 
 */

namespace ch03
{
    internal class _4_While
    {
        static void Main1(string[] args)
        {
            //1부터 10까지의 합
            // while 뒤에는 조건식만, 초기식은 while의 앞에, 증감식은 while의 뒤에 

            int sum = 0;    
            int k  = 1;

            while (k <= 10)
            {
                sum += k;

                k++;
            }

            Console.WriteLine("1부터 10까지의 합 : "+sum);


            // while의 경우 조건식에 따라서 한 번도 실행되지 않을 수도 있다.
            // do ~ while, 일단 1번은 실행한 후에 while의 조건에 따라 반복을 할 것인지 말 것인지를 확인하는 것.
            int tot = 0;
            int n = 1;

            do
            {              

                if (n%2 == 0)
                {
                    tot += n;

                }
                n++;           


            } while (n <= 10);

            Console.WriteLine("1부터 10까지의 짝수합 : "+tot);

            // bradk
            int num = 1;

           while (true)                          // 이거만 있으면 무한반복, 뒤에 if를 준다
            {
                if ( num % 5 == 0 && num % 7 == 0)
                {
                    break;                            // if를 만족하면 멈춰라
                }
                num++;
            }

            Console.WriteLine("5와 7의 최소공배수 : " + num);


            //continue

            int total = 0;
            int j = 0;

            while(j <= 10)
            {

                j++;

                if (j % 2 == 1)
                {
                    continue;                          // if를 만족하면 반복문의 처음으로 이동하여 계속해라
                }

                total += j;
            }


            Console.WriteLine("1부터 10까지의 짝수합 : "+total);


        }
    }
}
