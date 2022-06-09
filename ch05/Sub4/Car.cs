using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch05.Sub4
{
    internal class Car
    {
        

        // 속성(필드(변수)) : 상속관계에서 자식이 참조(사용)할 수 있게끔 프라이빗을 프로텍티드로 수정, 외부에서는 참조할 수 없다
        protected string name;
        protected string color;
        protected int speed;
       

        
        // 생성자
        public Car(string name, string color, int speed)
        {
            this.name = name;
            this.color = color;
            this.speed = speed;
        }



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
            Console.WriteLine("차량속도 : " +speed);
            
            Console.WriteLine("---------------------");
        }


        // static 이 붙어있는 메서드를 클래스 메서드라고 한다.  객체지향 프로그래밍에서는 쓸 일이 없다. 우리가 설정할 일이 없기 때문에.
        // 이걸 이용해서 소나타 그랜저 등등 만들고 상속을 이용해서 트럭도 만든다.





    }
}
