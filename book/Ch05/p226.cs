using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch05             // namespace라는 게 클래스들을 모아놓은 것이기 때문에 교재에 있는 것처럼 클래스 안에 클래스를 넣는 것보다는 따로 만들어라
{

    class Product
    {
        public string name;
        public int price;
    }



    internal class p226
    {
       


        static void Main1(string[] args)
        {
            Product p1 = new Product();

            p1.name = "자";
            p1.price = 2000;

            Console.WriteLine(" " + p1.name + " : " + p1.price);

            // Console.WriteLine(p); 희한한 게 나옴
        }
    }
}
