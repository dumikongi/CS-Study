using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book.ch04
{
    internal class p168
    {
        static void Main1(string[] args)
        {
            int output = 1;

            for(int n = 1; n<= 20; n++)
            {
                output *= n;
            }

            Console.WriteLine(output);
        }
    }
}
