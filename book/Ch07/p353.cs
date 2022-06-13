using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// 생성자는 인스턴스를 생성하는 가장 첫 단계다. 생성자 호출순서와 방법을 꼭 기억해야 한다. 


namespace book.Ch07
{
    internal class p353
    {
        class Parent
        {
            public Parent() { Console.WriteLine("Parent()"); }
            public Parent(int param) { Console.WriteLine("Parent(int param)"); }
            public Parent(string param) { Console.WriteLine("parent(string param)"); }
            
        }

        class Child : Parent
        {
            public Child() : base(10)                              // 10을 적음으로써 Parent(int Param)부모 생성자를 호출한다.
            {
                Console.WriteLine("Child() : base(10)");
            }

            public Child(string input) : base(input)
            {
                Console.WriteLine("Child(string input) : base(input)");
            }


        }

        static void Main1(string[] args)
        {
            Child childA = new Child();
            Child childB = new Child("blabla");
        }

        
    }
}
