using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book.Concept
{
    internal class p284
    {
        class Product
        {
            public static int counter = 0;
            public string name;
            public int id;
            public int price;

            public Product(string name, int price)
            {
                counter = counter + 1;
                this.name = name;
                this.id = counter;
                this.price = price;
            }
        }

        static void Main1(string[] args)
        {
            Product productA = new Product("dddd", 555);
            Product productB = new Product("aaaa", 255);


            Console.WriteLine(productA.id + ". " + productA.name + " : " +productA.price);
            Console.WriteLine(productB.id + "." + productB.name + ":" +productB.price);
            Console.WriteLine(Product.counter);
        }
    }
}
