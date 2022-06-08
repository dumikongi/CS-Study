using ch05.Sub2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 
 * 날짜 : 20222 / 06 / 08
 * 이름 : 허락녕
 * 내용 : 캡슐화 실습하기
 *
 * 캡슐화
 * - 캡슐화는 객체의 내용(필드)를 외부에서 참조하지 못하도록 객체의 정보를 은닉하는 특성을 말한다.
 * - 캡슐화를 위한 접근제한자 public, private, protected를 이용한다.
 * - 은닉된 정보의 안전한 제공을 위해 Getter와 Setter를 제공한다.(프로피티)
 * 
 * Sub1에서 Sub2로 바뀐다
 */




namespace ch05
{
    internal class _2_EnCaps
    {
        static void Main1(string[] args)
        {
            // 객체 생성과 초기화 (생성자 호출)
            Account kb = new Account("국민은행", "13513", "이씨", 54000);

            // 1. 참조변수 생성(스택) 2.뉴어카운트(힙에 객체 생성) 3. 생성자와 초기화 실행(객체에 속성들 생김). 4.대입(주솟값) 

            kb.Deposit(10000);
            kb.Withdraw(5000);

            // 캡슐화로 취약코드 예방
            // kb.balance--;                         // 이런 식으로 접근해서 잔액을 건들 수도 있다. 이를 막기 위해 캡슐화를 한다.  
            // kb.balance += 10;


            kb.Show();



            Car sonata = new Car("붕붕이", "빨간색", 0);
            Car bmw = new Car("붕붕이2", "흰색", 0);


            // setter 실행
            sonata.Speed = -100;
            sonata.Name = "EF소나타";

            // getter 실행
            Console.WriteLine("sonata 객체 name : "+sonata.Name);


            sonata.SpeedUp(100);
            sonata.SpeedDown(30);

            sonata.Show();
            bmw.Show();
        }
        
    }
}
