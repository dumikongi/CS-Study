using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// 변수의 충돌

namespace book.Ch07
{
    internal class p359
    {
        class Parent
        {
            public int variable = 20;
        }

        class Child : Parent
        {
            public string variable = "shadowing";
        }

        static void Main1(string[] args)
        {
            Child child = new Child();
            // Console.WriteLine(child.variable); 
            // 부모클래스에 있는 int 자료형의 변수를 사용하고 싶다면 아래처럼 바꾸면 된다.
            Console.WriteLine(((Parent)child).variable);
            
        }
    }
}
