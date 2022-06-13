using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace book.Ch07
{
    internal class p354
    {
        class Parent
        {
            public static int counter = 0;

            public void CounterParent()
            {
                Parent.counter++;
            }
        }

        class Child : Parent
        {
            public void CounterChild()
            {
                Child.counter++;
            }
        }

        static void Main1(string[] args)
        {
            Parent parent = new Parent();
            Child child = new Child();

            parent.CounterParent();
            child.CounterChild();

            Console.WriteLine(Parent.counter);
            Console.WriteLine(Child.counter);
        }
    }
}


// 클래스 변수가 각각의 클래스에 소속되어 있으므로 부모카운터, 자식카운터 모두 1이 나올 거라고 생각하지만 그렇지 않다
// 클래스 변수는 상속되어도 공유가 되기 때문에 둘 다 2이다. 
