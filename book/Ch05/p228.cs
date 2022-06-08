using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book.Ch05
{
    class Product
    {
        public string name;
        public int price;
    }
    internal class p228
    {
        static void Main1(string[] args)
        {
            Product pA = new Product() { name = "감자", price = 1100 };
            Product pB = new Product() { name = "고구마", price = 1500 };


            Console.WriteLine(pA.name + ' ' + pA.price);
        }
    }
}
