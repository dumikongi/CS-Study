using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book.Ch07
{
    internal class p340
    {
        static void Main1(string[] args)
        {
            /*
            List<Dog> Dogs = new List<Dog>() { new Dog(), new Dog(), new Dog() };
            List<Cat> Cats = new List<Cat>() { new Cat(), new Cat(), new Cat() };

            이것을 아래처럼 간단하게 할 수 있다.
            */

            List<Animal> Animals = new List<Animal>()
            {
                new Dog(), new Dog(), new Dog(), new Dog(), new Dog(), new Cat(), new Cat(), new Cat()
            };


            foreach(var item in Animals)
            {
                item.Eat();          //item. 뒤에 우리가 만들지 않은 메서드가 포함되어 있다. 이것들은 Object클래스의 메서드 중 일부다. 모든 클래스는 Object클래스의 상속을 받는다.
                item.Sleep();

                // Animal 리스트에 있는 요소들이 Dog클래스라면 Bark() 메서드를 호출하고
                // Cat클래스라면 Meow()메서드를 호출하게 만들려면 어떻게 해야하나?
                // 자식클래스에 있는 메서드를 사용하려면, 자식클래스로 자료형 변환을 해줘야 한다.
                // ((Cat)item).Meow(); 이렇게 해버리면 item내부의 Dog클래스들이 변환되지 않는다.
            }




        }
    }
}
