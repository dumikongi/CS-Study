using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// as라는 키워드를 사용해서 자료형 변환을 할 수 있다. 하지만 as키워드를 사용해 자료형을 변환하면 변환에 실패해도 예외가 발생하지 않는다. 
// 그저 변환에 실패했으니 null(아무 것도 아닌 값)을 넣게 된다.

namespace book.Ch07
{
    internal class p350
    {
        static void Main1(string[] args)
        {
            List<Animal> Animals = new List<Animal>()
            {
                new Dog(), new Dog(), new Dog(), new Dog(), new Dog(), new Cat(), new Cat(), new Cat()
            };

            foreach(var item in Animals)
            {
                item.Eat();
                item.Sleep();

                var Dog = item as Dog;
                if (Dog != null) { Dog.Bark(); }

                var Cat = item as Cat;
                if (Cat != null) { Cat.Meow(); }

                
            }
        }
    }
}
