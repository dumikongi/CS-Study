using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book.Ch07
{
    internal class p351
    {
        class Parent
        {
            public Parent()
            {
                Console.WriteLine("부모생성자");
            }
        }

        class Child : Parent
        {
            public Child()
            {
                Console.WriteLine("자식생성자");
            }
        }

        static void Main1(string[] args)
        {
            Child child  = new Child(); 
        }
       
    }
}
