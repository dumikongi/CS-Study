﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book.ch02
{
    internal class p109
    {
        static void Main1(string[] args)
        {
            long longNumber = 2147483647L + 2147483647L;
            int longToInt = (int)longNumber;
            Console.WriteLine(longToInt);

            double doubleNumber = 52.27310332;
            int doubleToInt = (int)doubleNumber;
            Console.WriteLine(doubleToInt);
           
        }
    }
}
