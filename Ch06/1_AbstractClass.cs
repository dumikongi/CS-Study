using Ch06.Sub1;                         // 이거 원래 자동으로 붙는 게 아닌가??
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/06/13
 * 이름 : 허락녕
 * 내용 : 추상클래스 실습하기 교재 p230
 * 
 * 추상클래스는 객체를 생성할 수 없다. = 인스턴스화가 되지 않는다.
 * 곹통의 기능은 하나의 메서드로 구현하고 개별적인 기능은 상속받아 오버라이드 메서드로 구현시키는 추상메서드를 갖는 클래스
 * 오직 상속을 목적으로 설계되는 클래스
 */



namespace Ch06
{    
    internal class _1_AbstractClass  
    {
        static void Main1(string[] args)
        {
            // Car car = new Car(); 추상클래스라서 객체 생성이 안 된다. 상속의 역할만 하는 것



            Car sedan = new Sedan("그랜저", "검정색", 0 , 2000);       // 제일 앞에 다형성을 적용하기 위해서 세단이 아니라 카로
            Car truck = new Truck("포터", "파란색", 0, 1);             // 다형성을 잘 활용할 줄 알아야 한다.

            sedan.SpeedUp(100);
            sedan.SpeedDown(20);
            sedan.Show();

            sedan.SpeedUp(80);
            sedan.SpeedDown(10);
            sedan.Show();


        }

    }
}
