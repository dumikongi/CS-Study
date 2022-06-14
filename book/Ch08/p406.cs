using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 * 구조체는 생성자를 선언할 때, 클래스와 달리 매개변수 없는 생성자를 선언할 수 없다.
 *  
 *  괄호 안에 매개변수를 반드시 적어야 한다. 
 *  왜냐면 매개변수가 없는 생성자는 자동으로 정의되기 때문이다.
 * 
 */
namespace book.Ch08
{
    internal class p406
    {
        struct Point
        {
            public int x;
            public int y;

            public Point(int x, int y)                       // 여기에서 괄호 안이 비워있으면 에러
            {
                this.x = x;
                this.y = y;     

            }
        }


        static void Main1(string[] args)
        {

            // 매개변수 없는 생성자로 구조체의 인스턴스를 생성하고 멤버 변수를 출력
            Point p1 = new Point();            // 매개변수 없는 생성자 여기서는 가능

            Console.WriteLine(p1.x);
            Console.WriteLine(p1.y);
        }

    }
}
