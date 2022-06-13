using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book.Ch07
{
    internal class Animal
    {
        public int Age { get; set; }

        public Animal() { this.Age = 0; }

        public void Eat() { Console.WriteLine("냠냠 먹습니다."); }
        public void Sleep() { Console.WriteLine("쿨쿨 잡니다."); }

    }

    internal class Dog : Animal           //클래스의 부모자식관계가 형성되면 자식클래스는 부모클래스의 public 또는 protected 멤버에 접근할 수 있다. 
    {

        /* 자식클래스에서 부모클래스에서 정의한 멤버를 사용하고 싶다면 다음과 같이 한다. -> 이게 무슨 말일까? 상속을 받지 않겠다는 말인가?
        
        public void Test()
        {
            Eat();
            Sleep();
        }
      
        */

        public string Color { get; set; }
        public void Bark() { Console.WriteLine("왈왈 짓습니다."); }
    }

    internal class Cat : Animal
    {
        public void Meow() { Console.WriteLine("왈왈 짓습니다."); }
    }


    
    
    
}
