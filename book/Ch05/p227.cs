using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch05
{
    internal class p227
    {
        static void Main1(string[] args)
        {
            Product p2 = new Product();

            p2.name = "볼펜";
            p2.price = 1500;

            Console.WriteLine(p2.name + " : " + p2.price);
        }
    }
}
