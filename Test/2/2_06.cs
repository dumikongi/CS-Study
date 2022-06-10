using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._2
{
    internal class _2_06
    {      
      
      
       
        static void Main1(string[] args)
        {

            intro();                       // 이게 없으면 '변수 a의 값을 입력 : '부터 시작한다. 실행을 시키면 static void Main에서 시작하는데
                                           // intro();가 없으면 아래의 input이 실행하게 되고 따라서 위의 input으로 가서 시작하게 된다.
            int a = input('a');
            int b = input('b');
            
            int output =  add(a, b);
            result(output);
        }



        public static void intro()
        {
            Console.WriteLine("****** START ******");
            Console.WriteLine("두 개의 정수를 입력");
        }



        public static int input(char name)
        {
            Console.Write("변수 " + name + " 값 입력 : ");
            int value = int.Parse(Console.ReadLine());
            return value;
        }


        public static void result(int Val)
        {
            Console.WriteLine("덧셈 결과 : " + Val);
            Console.WriteLine("*******END******");
        }

        public static int add(int x, int y)
        {
            return x + y;
        }






    }







}
