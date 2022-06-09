using ch05.Sub5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



/*
 * 날짜 :2022/06/09
 * 이름 : 허락녕
 * 내용 : 다형성 실습하기 교재 p340
 * 
 * 다형성(Polymorphism)
 * - 상속관계에서 부모클래스의 기능이 자식 클래스에서 여러 기능으로 변하는 특성
 * - 생성된 객체의 타입선언을 부모클래스 타입으로 선언
 * 
 * 
 * 객체지향 프로그래밍에서 다형성을 활용해서 프로그램의 반복을 줄이고 유연성을 높인다. 
 * ex) 부모클래스의 move가 자식사자클래스에서는 run, 자식독수리클래스에서는 fly, 자식물고기클래스에서는 swim로 바뀌게 되는 것
 * 
 */

namespace ch05
{
    internal class _6_Polymorphism
    {
        static void Main1(string[] args)
        {
            // 객체 생성
            Animal a1 = new Tiger();         // 제일 앞에 타이거가 아닌 애니멀을 적는 것을 다형성이라고 한다
            Animal a2 = new Eagle();         // a2는 사실 Eagle이지만 Animal로 위장했다
            Animal a3 = new Shark();

            a1.Move();                // a1의 무브는 애니멀의 무비이긴 하지만 오버라이드 되었긴 때문에 결국엔 타이거의 무브이다
            a2.Move();
            a3.Move();

            // a1.Hunt();              // a1은 애미멀을 참조하기 때문에 타이거에 있는 헌트를 쓸 수 없다

            // 객체타입 캐스팅
            Tiger tiger = (Tiger)a1;         // 위의 문제 때문에 a1을 다시 타이거로 강제로 캐스팅, 
            Eagle eagle = a2 as Eagle;       // (Eagle)a2와 같은 것, as연산자
            Shark shark = (Shark)a3;


            tiger.Hunt();
            eagle.Hunt();
            shark.Hunt();


            //객체 타입 확인
            if (a1 is Tiger)
            {
                Console.WriteLine("a1은 타이거입니다.");
            }

            if(a2 is Eagle)
            {
                Console.WriteLine("a2는 이글입니다.");
            }

            if(a3 is Shark)
            {
                Console.WriteLine("a3는 샤크입니다.");
            }




        }
    }
}
