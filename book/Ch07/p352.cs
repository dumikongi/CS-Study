using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book.Ch07
{
    internal class p352
    {
       class Parent
        {
            public Parent()
            {
                Console.WriteLine("부모생성자");
            }
        }


       class Child
        {
            public Child() : base()                 // 부모생성자 호출을 명시적으로 지정하고 싶을 땐 base()를 쓴다. 이게 없으면 부모생성자가 모두 호출
            {
                Console.WriteLine("지식생성자");
            }
        }

        static void Main1(string[] args)
        {
            Child child = new Child();
        }
    }
}
