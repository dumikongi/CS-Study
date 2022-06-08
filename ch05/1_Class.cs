using ch05.Sub1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 * 날짜 : 20222/06/08
 * 이름 : 허락녕
 * 내용 : 클래스와 객체 실습하기 교재 p203
 * 
 * - stack은 차곡차곡 정보가 쌓이고, heap은 마구잡이로 정보가 저장된다.
 * - 변수는 스택에 저장이 된다. 객체는 heap영역에 저장된다.
 * - 
 */

namespace ch05
{
    internal class _1_Class          // 클래스와 메서드는 대문자로 시작, 변수는 소문자로
    {
        static void Main1(string[] args)
        {
            // 객체 생성
            Car sonata = new Car();  // 'ctrl와 .' 을 동시에 누르면 Car클래스와 연결된다.                           
                                     // Stack에 있는 소나타라는 참조변수(참조변수는 객체다)
                                     // Heap에 있는 Car라는 클래스(그 안에 속성 기능 모두 포함되어있음) -> Heap에 저장된 걸 인스턴스라고 한다               
                                     // stack은 4바이트, heap은 16바이트

            // 객체 초기화
            sonata.name = "소나타";
            sonata.color = "흰색";
            sonata.speed = 0;        // . 누르면 참조연산자가 나온다. 그 중에 따로 설정해두었던 속성을 가져옴.
                                     // 참조변수가 해당 인스턴스에 할당된다

            // 객체 기능
            sonata.SpeedUp(10);
            sonata.SpeedUp(50);
            sonata.SpeedDown(20);
            sonata.Show();
                                     // 참조변수가 해당 인스턴스에 할당된다

            // 객체 생성 BMW 검정색
            Car bmw = new Car();

            bmw.name = "붕붕이";
            bmw.color = "빨간색";
            bmw.speed = 0;

            bmw.SpeedUp(10);
            bmw.SpeedUp(110);
            bmw.SpeedDown(20);

            bmw.Show();             // heap에 저장된 참조변수들을 가지고 온다.       // show는 Car클래스에 있는 show를 가지고 온다



            // 객체 생성
            Account kb = new Account();                     // 제일 위에 폴더가 유징 선언 되어있기 때문에 콘트롤 점 안 눌러도 자동으로 연결된다.

            //초기화
            kb.bank = "국민은행";
            kb.id = "21213066";
            kb.name = "김씨";
            kb.balance = 200;


            // 기능
            kb.Deposit(25000);
            kb.Withdraw(5000);
            kb.Show();

            // nh
            Account nh = new Account();

            nh.bank = "농협은행";
            nh.id = "646515";
            nh.name = "Paul";
            nh.balance = 800000;

            nh.Deposit(113300);
            nh.Withdraw(44550);
            nh.Show();



                
        }
    }
}
