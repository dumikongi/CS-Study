﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 *  날짜 : 2022/06/20
 *  이름 : 허락녕    
 *  내용 : 예외처리 Try 실습하기 교재 p467
 *  
 *  
 *  
 *  
 *  
 */


namespace Ch07
{
    internal class _6_Try
    {
        class Apple
        {
            public void Show()
            {
                Console.WriteLine("Apple Show...");
            }
           
        }

        static void Main1(string[] args)
        {
            //////////////////////////////////
            /// try- catch
            //////////////////////////////////
            // 상황 1 : 어떤 수를 0으로 나눌 때

            int num1 = 1;
            int num2 = 0;
            int rs1 = 0, rs2 = 0, rs3 = 0, rs4 = 0;


            try
            {
                rs1 = num1 + num2;
                rs2 = num1 - num2;
                rs3 = num1 * num2;
                rs4 = num1 / num2;
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);

            }


            Console.WriteLine("rs1 : " + rs1);
            Console.WriteLine("rs2 : " + rs2);
            Console.WriteLine("rs3 : " + rs3);
            Console.WriteLine("rs4 : " + rs4);

            // 코드의 일관성을 위해서 위처럼 한다.

            /*
            int rs1 = num1 + num2;
            int rs2 = num1 - num2;
            int rs3 = num1 * num2;
            int rs4 = 0;                   // 1. rs4를 트라이 바깥에서 선언해줘야 

            try
            {
                rs4 = num1 / num2;   // 여기에는 int 없다.         // int rs4 = num1 / num2;   3. 이렇게 놔두면 rs4는 트라이 안에서만 쓸 수 있는 지역변수이므로
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);

            }
            

            Console.WriteLine("rs1 : "+rs1);
            Console.WriteLine("rs2 : "+rs2);
            Console.WriteLine("rs3 : "+rs3);
            Console.WriteLine("rs4 : "+rs4);        // 2. 여기에서 rs4에 빨간줄이 없어진다.


            */


            //상황2 : 배열의 인덱스 범위를 벗어났을 때
            int[] arr = { 1, 2, 3, 4, 5 };

            try
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.Write(arr[i] + " ");
                }

            }
            catch(Exception e)           // 익셉션 객체 e, 익셉션은 클래스(???)
            {
                Console.WriteLine(e.Message);
            }

            // 상황 3 : NULL 포인트 에러

            Apple a1 = new Apple();
            //Apple a2;              // 이번엔 참조변수만 선언하고 new를 하지 않았다, 할당하지 않았다. 인스턴스를 갖지 않는다.
            Apple a2 = null;
            // a2.Show();                  // 이게 널포인트에러다

            try
            {
                a1.Show();
                a2.Show();
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }




                                   



















            //////////////////////////////////
            /// try-catch-finally
            //////////////////////////////////
            








            Console.WriteLine("프로그램 종료...");
        }







    }
}
