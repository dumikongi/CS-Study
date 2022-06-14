using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 * 날짜 : 2022/06/14
 * 이름 : 허락녕
 * 내용 : 구조체 실습하기 교재 p404
 * 
 * 
 * 구조체가 발달해서 클래스가 되었다. 
 * 필드 - 속성, 메서드 - 기능
 * 
 * 구조체(structure)
 * - 간단하게 객체를 만들 때 사용하는 구조 형식
 * - 클래스와 동일하지만 몇 가지 제한(상속x, 캡슐화x)
 * 
 * 캡슐화가 안 된다 = private이 안 된다.
 * 
 */

namespace Ch06
{
    internal class _3_Structure
    {
        struct MyPoint                 // 클래스와 비슷하다 스트럭처는 스택에 생성
        {
            public int x;
            public int y;   

            public MyPoint(int x, int y)
            {
                this.x = x; 
                this.y = y;
            }


            //필드 속성 출력 메서드
            public override string ToString()                      // 오버라이드는 부모클래스를 대체하는 것. 여기서 부모는 오브젝트다
            {                                                          // ToString 어쩌고 저쩌고 했는데..
                return String.Format($"x : {x}, y : {y}");
            }

        }


        static void Main(string[] args)
        {
            MyPoint p1;                            // 스트럭처는 new없이 바로 한다. 굳이 객체 생성 따로 할 필요 없다.
            p1.x = 10;
            p1.y = 20;

            Console.WriteLine("p1 : "+p1.ToString());

            MyPoint p2 = new MyPoint(20, 30);                   // new해도 된다. 이때에는 반드시 매개변수를 넣어야 한다. 넣지 않고는 생성자 생성할 수 없다.
            Console.WriteLine("p2 : "+p2.ToString());

        }
    }
}
