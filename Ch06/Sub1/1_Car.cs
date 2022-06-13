using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch06.Sub1
{
    abstract class Car                       //abstract를 붙인다 왜 추상클래스니깐
    {
       

        // 속성(필드(변수))
        protected string name;              //protected : 이걸 해야 세단트럭에서 네임등에 빨간줄 없다
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
        public abstract void SpeedUp(int speed);         //virtual : 오버라이드하려고      //abstract        //virtual은 빠진다 : 추상클래스니깐

        /*                                               // 세단이랑 트럭에서 따로 지정해주므로 필요 없다
        {this.speed += speed;}                  
    } 
        */


        public abstract void SpeedDown(int speed);
            /*
        {this.speed -= speed;}     
            */
        
        public virtual void Show() 
        {
            Console.WriteLine("=====================");
            Console.WriteLine("차량명 : " +name);                        
            Console.WriteLine("차량색 : "+color);
            Console.WriteLine("차량속도 :" +speed);
        }
        



        

    }
}
