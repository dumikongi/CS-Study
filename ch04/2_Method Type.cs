using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 * 날짜 : 2022/06/07
 * 이름 : 허락녕
 * 내용 : Method Type 실습하기 교재 p265
 * 
 */
namespace ch04
{
    internal class _2_Method_Type         // class 안에 매서드가 포함되는 거
    {


        static void Main1(string[] args)
        {
            // 매서드 호출 


            double y1 = Type1(0.1);            //인자값(매개변수, x에 해당하는 것) 0.1
            double y2 = Type1(1.2);


            Console.WriteLine("y1 : " + y1);
            Console.WriteLine("y2 : " + y2);

            Type2(true);                     // 타입2는 리턴이 없으므로 앞에 대입연산자(와이값에 해당하는 문자)을 지정해줄 필요가 없이 끝내면 된다.
            Type2(false);


            String result = Type3();
            Console.WriteLine("Type3 result :" + result);

            /*
            Type4();
            */
        }


        // Type 1: 매개변수 o, 리턴값 o


        public static double Type1(double x)
        {
            double y = x + 3.14;
            return y;
        }



        // Type 2: 매개변수 o, 리턴값 x
        public static void Type2(bool status)                         // void는 없다는 뜻
        {
            if (status)
            {
                Console.WriteLine("참입니다.");
            }

            else
            {
                Console.WriteLine("거짓입니다.");
            }
        }


        // Type 3: 매개변수 x, 리턴값 o

        public static string Type3()                      //Type3(void)라고 써도 되지만 그냥 비워둔다
        {
            int n1 = 1, n2 = 2;

            if (n1 > n2)
                return "n1은 n2보다 크다.";

            else
                return "n1은 n2보다 크지 않다.";
        }


        /*
        // Type 4: 매개변수 x, 리턴값 x
        public static void Type4()
        {
            double result = double.Parse(Type4());
            Console.WriteLine("Type4 result : " + result);
        }
        */

    }

}
