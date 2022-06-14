using Ch06.Sub3;                         // 유징 선언 컨트롤 쩜 누르면 된다
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/* 
 * 날짜 : 2022/06/14
 * 이름 : 허락녕
 * 내용 : 제네릭 실습하기 교재 p395
 * 
 * 
 * 제네릭(Generic)
 * - 클래스 내부의 변수의타입을 동적으로 일반화시키는 문법
 * - 제네릭 사용으로 클래스가 범용성을 갖도록 활용
 * 
 * 
 * 수의 타입이 객체를 생성할 때 지정되는 것, 그래서 동적이라는 표현을 쓴다. 그래서 치환변수가 쓰인다. 
 * 
 * 
 */

namespace Ch06
{

    class FruitBox<T>                         //class FruitBox로는 애플과 바나나를 모두 할 수 없다  T: 치환변수
    {
        private T fruit;                                  // private Apple fruit; -> T를 붙여야한다 -> 범용성이 목적

        // Getter, Setter를 이용해서 초기화하기              // 생성자를 이용하는 대신 게터,세터를 이용해서 초기화하는 것
         public T Fruit                                                   // public Apple Fruit
        {
            get { return fruit; }
            set { fruit = value; }
        }
    
    
    }

    internal class _4_Generic
    {
        static void Main1(string[] args)
        {
            Apple apple = new Apple("한국", 3000);
            Banana banana = new Banana("대만", 4000);

            FruitBox<Apple> box1 = new FruitBox<Apple>();    // T를 Apple로 치환한다
            box1.Fruit = apple;                              //Fruit은 위에 있는 set을 호출한 것으로 value값이 apple인 것이다. -> 이게 setter다
            box1.Fruit.show();                               // 게터를 이용해서 호출


            FruitBox<Banana> box2 = new FruitBox<Banana>();
            box2.Fruit = banana;                           // Apple Fruit이라서 코드상 정적상 오류로 바나나에 빨간줄  -> <T>를 이용한다
            box2.Fruit.show();

        }
    }
}
