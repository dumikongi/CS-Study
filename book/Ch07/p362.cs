using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book.Ch07
{
    internal class p362
    {
        class Parent
        {
            public virtual void Method()
            {
                Console.WriteLine("부모의 메서드");
            }
        }

        class Child : Parent
        {
            public override void Method()
            {
                Console.WriteLine("자식의 메서드");
            }
        }

        static void Main1(string[] args)
        {
            Child child = new Child();
            child.Method();
            ((Parent)child).Method();          // p361과 달리 override하면, 즉 덮어쓰게 되면 자식에서 정의한 메서드가 호출된다.
        }

    }
}
