using ch05.Sub4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



/*
 * 날짜 : 2022/06/09
 * 이름 : 허락녕
 * 내용 : 클래스 상속 실습하기 교재 p331
 * 
 * 상속 
 * - 기존 클래스의 속성과 기능을 그대로 파생 클래스로 물려줘 클래스를 확장하는 문법
 * - 공통적인 내용을 부모클래스에 두고 자식 클래스에서 상속받아 일관성있고 효율적인 프로그래밍 수행
 */

namespace ch05
{
    class Parent
    {
        private int num1;
        private int num2;

        public Parent(int num1, int num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }

        public int Plus()
        {
            return num1 + num2;
        }
    }


    class Child : Parent                        // : 상속문법, 자식이 부모를 바라본다, 자식은 부모가 가지고 있는 속성을 초기화(실행)할 의무가 있다, 그래서 다음을 실행
    {
        private int num3;
        private int num4;

        public Child(int num1, int num2, int num3, int num4) : base(num1, num2)      //base는 부모를 지칭
        {
            this.num3 = num3;
            this.num4 = num4;   
        }

        public int Minus()
        {
            return num3 - num4;
        }

        /*        자식이 새로운 메서드를 가지지 않는다면 간단히 이렇게 된다
        public Child(int num1, int num2) : base(num1, num2)      //base는 부모를 지칭
        {
        }
        */
    }





    internal class _4_Inheritance
    {
        static void Main1(string[] args)
        {
            // 상속 객체
            Child c1 = new Child(1, 2, 3, 4);               //1이 int num1로, num1로, 부모클래스의 num1로 간다
            Child c2 = new Child(11, 22, 33, 44);
            // c1, c2는 스택에, num1,2,3,4는 힙에 생긴다
                                                            
            Console.WriteLine("c1 Plus : "+c1.Plus);         // child는 플러스 기능이 없지만 부모의 속성을 이어받았기 때문에 플러스가 된다
            Console.WriteLine("c1 Plus : "+c1.Minus);      
            Console.WriteLine("c2 Plus : "+c2.Plus);      
            Console.WriteLine("c2 Plus : "+c2.Minus);





            // Car 상속 객체 생성
            Sedan sedan = new Sedan("그랜저", "검정색", 0, 2000);
            Truck truck = new Truck("봉고", "파란색", 0, 1);


            sedan.SpeedUp(40);
            sedan.Show();

            //Account 상속 객체 생성
            StockAccount kb = new StockAccount("KB증권", "156465161", "김유신", 1000, "삼성전자", 0, 0);
            kb.Deposit(1000000);
            kb.Buy(10, 700000);
            kb.Sell(5, 75000);
            kb.Show();
            

            // 오버로딩 : 매개변수를 가지고 메서드를 구분하는 것



        }




    }
}
