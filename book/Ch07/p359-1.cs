using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// 메서드의 충돌 -> 이 때에는 하이딩(public new void Method)을 할지 오버라이딩(public override void Method)할지 결정할 수 있다.
// new를 붙이면 하이딩, virtual과 override를 붙이면 오버라이딩
// 하이딩은 멤버 전체(변수, 메서드 등)에서 모두 일어나지만, 오버라이딩은 메서드와 관련해서만 일어난다.

namespace book.Ch07
{
    internal class p359_1
    {
        class Parent
        {
            public void Method()
            {

                Console.WriteLine("부모의 메서드");
            }
        }

        class Child : Parent
        {
            public void Method()
            {
                Console.WriteLine("자식의 메서드");
            }
        }


        static void Main1(string[] args)
        {
            Child child = new Child();
            child.Method();
            ((Parent)child).Method();   
        }
    }
}
