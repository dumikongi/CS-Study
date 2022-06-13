using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 부모클래스와 자식클래스 사이에 같은 이름으로 멤버를 만든 경우에는 하이딩이라고 한다. 
// 하이딩 : 자식이 부모를 숨기는 것
// 섀도잉과 마찬가지로 가장 가까운 것을 사용한다. 
// 하이딩을 하게 되면(부모자식간에 같은 이름을 쓰면) 정상적인 상속을 막아버리게 된다.
// 섀도잉은 부모자식간이 아니라 같은 이름을 쓴 것 뿐.

namespace book.Ch07
{
    internal class p358
    {
        class Parent
        {
            public int variable = 273;
        }

        class Child : Parent
        {
            public string variable = "Shadowing";
        }

        static void Main1(string[] args)
        {
            Child child = new Child();
            Console.WriteLine(child.variable);
        }
    }
}
