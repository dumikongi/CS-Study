using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book
{
    internal class p366
    {
        class Animal
        {
            public virtual void Eat()
            {
                Console.WriteLine("냠냠");
            }
        }

        class Dog : Animal
        {
            public new void Eat()                        // virtual과 new를 쓰면 하이딩이 되고
            {
                Console.WriteLine("강아지사료를 먹습니다.");
            }
        }

        class Cat : Animal
        { 
            public override void Eat()                    // virtual과 override를 쓰면 오버라이딩이 된다. 
            {
                Console.WriteLine("고양이사료를 먹습니다.");
            }
        }
        static void Main1(string[] args)
        {
            List<Animal> Animals = new List<Animal>()
            {
                new Dog(), new Cat(), new Dog(), new Cat(), new Dog(), new Cat(), new Dog(), new Cat()
            };

            foreach (var item in Animals)
            {
                item.Eat();
            }

        }
    }
}
