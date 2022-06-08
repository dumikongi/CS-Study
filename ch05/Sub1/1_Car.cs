using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch05.Sub1
{
    internal class Car
    {
        // class를 만든다는 것은 속성과 기능을 정하고 구체화하는 것. 정해진 게 아니다 내가 설정하기 나름이다. 구현하기 나름

        // 속성(필드(변수))
        public string name;              // 퍼블릭 = 접근제한자???, 보통은 속성에서는 퍼블릭은 생략한다
        public string color;
        public int speed;                // 클래스의 멤버 speed



        // 기능(메서드) 
        public void SpeedUp(int speed)            // 함수의 변수 speed 
        {
            this.speed += speed;                  // 위의 두 speed가 헷갈리기 때문에 클래스의 멤버 speed에는 this를 붙인다
        } 
             
                     
        public void SpeedDown(int speed) 
        {
            this.speed -= speed;
        }     
        
        public void Show() 
        {
            Console.WriteLine("=====================");
            Console.WriteLine("차량명 : " +name);                        
            Console.WriteLine("차량색 : "+color);
            Console.WriteLine("차량속도 :" +speed);
        }
        // static 이 붙어있는 메서드를 클래스 메서드라고 한다. 이건 우리가 설정할 일이 없다. 객체지향 프로그래밍에서는 쓸 일이 없다
        // 이걸 이용해서 소나타 그랜저 등등 만들고 상속을 이용해서 트럭도 만든다.



        

    }
}
