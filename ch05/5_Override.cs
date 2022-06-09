using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/* 
 * 날짜 : 2022/06/09
 * 이름 : 허락녕
 * 내용 : 오버라이드 실습하기 교재 p361
 * 
 * 오버라이드
 * -부모클래스의 메서드를 자식클래스에서 다시 재정의(덮어쓰기) 하는 것
 * - 오버라이드를 통해 다형성을 실현한다.
 * 
 * 오버로딩 
 * - 이름은 같고 매개변수는 다른 메서드를 만드는 것
 */

namespace ch05
{
    class AAA 
    {
        public void Method1()
        {
            Console.WriteLine("AAA : Method1...");
        }

        public virtual void Method2()
        {
            Console.WriteLine("AAA : Method2...");
        }

        public virtual void Method3()
        {
            Console.WriteLine("AAA : Method3...");
        }
    }

    class BBB : AAA                    // hide = override, 부모의 Method를 자식이 덮어쓴다. 숨긴다. 
    {
        
        public new void Method1()             // Method Hiding : BBB의 메서드2가 AAA의 메서드2를 숨김
        {
            Console.WriteLine("BBB : Method1...");
        }

        
        public override void Method2()              // Method Override : BBB의 메서드2가 AAA의 메서드2를 덮어씌움
        {
            Console.WriteLine("BBB : Method2...");
        }

        public void Method3(int a)                    // Method Overload : AAA와 매개변수로 구분하므로 오버로드. BBB의 Method3와 AAA의 Method이 매개변수로 구분
        {
            Console.WriteLine("BBB : Method3...");
        }
    }
    class CCC : BBB 
    {
        
        public new void Method1()               // CCC의 Method1이 BBB의 Method1을 숨김
        {
            Console.WriteLine("CCC : Method1...");
        }

        public override void Method2()              // CCC의 Method2가 BBB의 Method2을 덮어씌움
        {
            Console.WriteLine("CCC : Method2...");
        }

        public override void Method3()                  // Method Override : CCC의 Method3이 AAA의 Method를 덮어씌움. 비비비의 메서드3은 매개변수가 있으므로
        {
            Console.WriteLine("CCC : Method3...");
        }
    }


    internal class _5_Override
    {
        static void Main1(string[] args)
        {
            AAA a = new AAA();
            BBB b = new BBB();
            CCC c = new CCC();

            a.Method1();
            a.Method2();
            a.Method3();
            Console.WriteLine();

            b.Method1();               
            b.Method2();              
            b.Method3();             // 매개변수가 없으므로 AAA의 메서드3이 나온다
            Console.WriteLine();

            c.Method1();                // 숨기면서 AAA의 메서드1이 출력
            c.Method2();                 // 덮으면서 CCC의 메서드2이 출력
            c.Method3();
            c.Method3(1);
            Console.WriteLine();
           
        }
    }
}
