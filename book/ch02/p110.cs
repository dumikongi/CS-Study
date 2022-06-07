using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book.ch02
{
    internal class p110
    {
        static void Main1(string[] args)
        {
            int intNumber = 2147483647;

            long intToLong = intNumber;
            Console.WriteLine(intToLong);

            double intToDouble = intNumber;
            Console.WriteLine(intToDouble);
        }
    }
}
