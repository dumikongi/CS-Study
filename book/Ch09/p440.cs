using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 * 하나의 클래스는 하나의 클래스만 상속받을 수 있다. 
 * 그런데 인터페이스를 사용한 다중 상속은 허용한다. 
 * 클래스 상속과 인터페이스 상속을 함께 활용하면 하나의 클래스가 여러 다형성을 가질 수 있게 된다.
 * 
 * 
 */

namespace book.Ch09
{
    internal class p440
    {
        class Parent { }

        class Child : Parent, IDisposable, IComparable
        {
            public int CompareTo(object? obj)
            {
                throw new NotImplementedException();
            }

            public void Dispose()
            {
                throw new NotImplementedException();
            }
        }


        Child child1 = new Child();
        Parent child2 = new Child();
        IComparable child3 = new Child();
        IDisposable child4 = new Child();

        
    }
}
