using ch05.Sub3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 * 날짜 : 20222/06/08
 * 이름 : 허락녕
 * 내용 : 클래스 변수, 클래스 메서드 실습 교재 p225
 * C#프로그램은 물리적인 메모리 공간을 논리적인 Stack, Heap, Data 영역으로 나누어 사용한다.
 * 스택은 연속적으로 쌓이고 빠짐. 힙은 객체를. Static을 선언한 클래스변수와 클래스변수는 Data영역에 쌓인다. 
 * 
 * 
 * 클래스변수, 메서드 (정적변수, 정적메서드)
 * -static 변수, Data 영역 메모리 공간에 하나의 클래스 변수로 관리
 * -클래스타입(객체 생성x)으로 직접 참조
 */


namespace Ch05
{
    class Increment
    {
        public int num1;     // 멤버변수 2개, int는 초기값이 0이다.  int num1 = 0; 과 같다
        public static int num2; // static을 붙이면서 num2는 데이터영역에 들어가게 된다.

        public Increment()     // Heap에 Increment 생김
        {
            num1++;
            num2++;

            Console.WriteLine("num1 : {0}, num2 : {1}", num1, num2);
        }

        public static void Add()
        {
            // static 메서드(클래스메서드)에서는 non-static 변수를 참조할 수 없다
            // num1++;
            num2++;

            Console.WriteLine("num2 :" +num2);
        }

    }
        
    internal class _3_Static
    {
        static void Main(string[] args)
        {
            Increment inc1 = new Increment();
            Increment inc2 = new Increment();
            Increment inc3 = new Increment();

            //클래스 변수, 클래스 메서드 실행
            Increment.num2 = 10;
            Increment.Add();

            //Heap에서 따로따로 저장보관하고 있을 필요가 없을 때 static을 이용하여 Data영역에서 한꺼번에 다룬다(?)

            // num2에 static이 없을 때 : 스택에 inc1,2,3이 생성됨, Heap에 num1,2가 하나씩 들어감 
            // num2에 static이 있을 때 : 스택에 inc1,2,3이 생성됨, Heap에 num1,2가 하나씩 들어감, Data영역에 num2가 생기면서 숫자가 1씩 커진다. 잘 모르겠음

            //Car 객체 생성
            Car car1 = new Car("현대차", "검은색", 0);
            Car car2 = new Car("기아차", "흰색", 0);
            Car car3 = new Car("쌍용차", "보라색", 0);

            car1.Show();
            car2.Show();
            car3.Show();

            //Calc 객체 가져오기



            Calc c1 = Calc.Instance;
            Calc c2 = Calc.Instance;           // Calc는 지금 프라이빗 되어있을 때 생성하는 방법
            Calc c3 = Calc.Instance;           // Calc cal = new Calc();          이건 프라이빗일 때 생성하는 방법
            Calc c4 = Calc.Instance;
            Calc c5 = Calc.Instance;             // 이게 다섯개 있다고 해서 5개가 아니다 데이터영역에 오직 하나만 있다. 






            int r1 = c1.Plus(1, 2);
            int r2 = c2.Minus(1, 2);
            int r3 = c3.Multi(1, 2);
            int r4 = c4.Div(1, 2);
            int r5 = c5.Plus(1, 2);


            Console.WriteLine("r1 : "+r1);
            Console.WriteLine("r2 : "+r2);
            Console.WriteLine("r3 : "+r3);
            Console.WriteLine("r4 : "+r4);
            Console.WriteLine("r5 : "+r5);

        }
    }
}
