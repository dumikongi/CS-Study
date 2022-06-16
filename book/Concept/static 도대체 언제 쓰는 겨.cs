using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 * 
 * static 한정자는 특정 개체가 아니라 해당 형식 자체에 속하는 정적 멤버를 선언하는 데 사용됩니다
 * static 키워드는 변수 혹은 함수 혹은 클래스가 객체(인스턴스) 단위가 아니라 클래스 단위로 생성, 사용되게 하는 키워드이다
 * 
 * num을 static 변수로 선언하게 되면 
 * 이제 객체 (마리오나 루이지) 단위가 아닌 클래스(캐릭터 클래스) 단위로 작동하며 
 * 사용할때도 Character.num 처럼 클래스명.변수 와 같이 사용한다
 * 따라서 캐릭터의 클래스의 생성자가 불릴 때마다 ++가 되고 이는 해당 클래스를 사용하는 전 객체가 공유한다.
 * 
 * 
 * 
 * 
 */


namespace book.Concept
{
    internal class static_도대체_언제_쓰는겨
    {
        /*
        class Character 
        { 
            public int num = 0; 
            public Character() 
            { 
                num++; 
            } 
        }

        class Program 
        { 
            static void Main(string[] args) 
            { 
                Character mario = new Character(); 
                Character luigi = new Character(); 
                Console.WriteLine(mario.num); // 여기에서는 Character.num할 수가 없다. 왜냐면 static이 없으므로
            } 
        }
        */

        class Character
        { 
            public static int num = 0;        // static 추가
            public Character()
            {
                num++;
            }
        }

        class Program
        {
            static void Main1(string[] args)
            {
                Character mario = new Character();
                Character luigi = new Character();
                Console.WriteLine(Character.num);           // static추가하면 여기에는  mario.num할 수가 없다. 왜냐면 static이 있으므로
            }
        }



    }
}
