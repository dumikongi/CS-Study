using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch05.Sub4
{
    internal class StockAccount : Account
    {

        private string stock;
        private int amount;
        private int price;

        public StockAccount(string bank, string id, string name, int balance, string stock, int amount, int price) : base(bank, id, name, balance)
        {
            this.stock = stock;
            this.amount = amount;
            this.price = price;
        }

        public void Sell(int amount, int price)
        {
            this.amount -= amount;
            base.balance += amount * price;                  //base를 붙이는 이유는 부모 크래스에 있는 발란스라는 것. 없어도 되긴 된다
        }

        public void Buy(int amount, int price)
        {
            this.amount += amount;
            base.balance -= amount * price;

        }

        public void Show()
        {
            base.Show();
            Console.WriteLine("주식종목 : " + stock);
            Console.WriteLine("주식수량 :" + amount);
            Console.WriteLine("주식가격 : " + price);


        }





    }
}
