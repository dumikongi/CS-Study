using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch05.Sub2
{
    internal class Account   
    {
        // 속성
        // 속성은 프라이빗이라고 생각해라 = 캡슐화 -> 이렇게 되면 생성을 못한다. 그래서 밑에 생성자가 만들어진다.
        private string bank;
        private string id;
        private string name;
        private int balance;            

        // 생성자 - 캡슐화된 속성을 초기화하기 위한 메서드
        // 반환타입없다 앞에 int 이런 거 없다. 생성만 할 수 있게 한다
        public Account(string bank, string id, string name, int balance)        //그래서 위에 있는 속성들을 초기화해줘야 한다. 
        {
            this.bank = bank;
            this.id = id;
            this.name = name;
            this.balance = balance;                     // 이 부분은 고민할 것 없이 그냥 기계적으로 해라

        }


        // 기능
        public void Deposit(int money)
        {
            this.balance += money;
        }
        public void Withdraw(int money)
        {
            this.balance -= money;
        }
        public void Show()
        {
            Console.WriteLine("=================");
            Console.WriteLine("은행명 : "+bank);
            Console.WriteLine("계좌번호 :"+id);
            Console.WriteLine("입금주 : "+name);
            Console.WriteLine("현재잔액 : " +balance);
            Console.WriteLine("-----------------");
        }






    }
}
