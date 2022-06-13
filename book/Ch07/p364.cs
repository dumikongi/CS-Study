using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book.Ch07
{
    internal class p364
    {
        class Animal
        {
            public void Eat()
            {
                Console.WriteLine("냠냠");
            }
        }

        class Dog : Animal
        {
            public void Eat()
            {
                Console.WriteLine("강아지사료를 먹습니다.");
            }
        }

        class Cat : Animal
        {
            public void Eat()
            {
                Console.WriteLine("고양이사료를 먹습니다.");
            }
        }

        static void Main1(string[] args)
        {
            List<Animal> Animals = new List<Animal>()
            {
                new Dog(), new Cat(), new Cat(), new Dog(), new Dog(), new Cat(), new Dog(), new Dog()
            };

            foreach(var item in Animals)
            {
                item.Eat();
            }
        }
    }
}



// 하이딩했으므로 부모의 메서드만 실행하게 된다. ????? 왜 앞에서는 이렇게 얘기 안 한 것 같은데?????