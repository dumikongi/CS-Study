using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 * 날짜 : 2022/06/14
 * 이름 : 허락녕
 * 내용 : 자주 사용하는 내장클래스 실습하기 교재
 * 
 * 
 * 
 * 
 */


namespace Ch06
{
    internal class _6_InteralClass
    {
        static void Main1(string[] args)
        {
            // Math 클래스, 객체를 생성하는 클래스가 아니다. 즉, new가 안 된다 Math의 멤버들은 static이다. 즉 메쓰 쩜 하면 바로 쓸 수 있다.
            Console.WriteLine("PI : "+Math.PI);
            Console.WriteLine("9의 제곱근 ; "+Math.Sqrt(9));
            Console.WriteLine("절댓값 : "+Math.Abs(-8));
            Console.WriteLine("올림값 : "+Math.Ceiling(5.55));
            Console.WriteLine("내림값 : " + Math.Floor(1.2));
            Console.WriteLine("반올림 : "+Math.Round(5.5));


            // Random 클래스     p207
            Random random = new Random();         // 객체 생성

            int rand1 = random.Next();
            Console.WriteLine("rand1 : "+rand1);
            
            int rand2 = random.Next(10);           // 0이상  10미만의 임의의 정수
            Console.WriteLine("rand2 : "+rand2);

            int rand3 = random.Next(1,10);              // 1이상 10미만의 임의의 정수
            Console.WriteLine("rand3 : " + rand3);

            double num1 = random.NextDouble();              // 0과 1사이의 실수
            Console.WriteLine("num1 : " + num1);

            double num2 = num1 * 10;                         // 0과 10 사이의 실수
            Console.WriteLine("num2 : " +num2);

            double num3 = Math.Ceiling(num2);            // 0과 10 사이의 정수
            Console.WriteLine("num3 : "+num3);





            // DateTime 클래스
            // 싱글톤 객체로서 new를 쓰지 않고 객체를 얻어온다

            DateTime now = DateTime.Now;
            Console.WriteLine("now : "+now);

            // 개별 시간 데이터 출력, 연, 월, 일, ,시, 분, 초
            Console.WriteLine("now : "+now.Year);
            Console.WriteLine("now : " + now.Month);
            Console.WriteLine("now : " + now.Day);
            Console.WriteLine("now : " + now.Hour);
            Console.WriteLine("now : " + now.Minute);
            Console.WriteLine("now : " + now.Second);

            // 문자열 Format  출력된 모양의 서식 정해주기
            string result1 = now.ToString("yyyy-MM-dd");
            Console.WriteLine("result1 : "+result1);

            string result2 = now.ToString("yy-MM-dd hh-mm-ss");
            Console.WriteLine("result2 : " + result2);


























            //DateTime 클래스






        }
    }
}
