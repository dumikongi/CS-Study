using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book.Ch06
{

    class Fibonacci1
    {
        public static long Get(int i)
        {
            if (i < 0) { return 0; }
            if ( i == 1 ) { return 1; }
            if ( i == 2 ) { return 2; }

            return Get(i - 2) + Get(i - 1);
        }
    }

    internal class p308
    {
        static void Main1(string[] args)
        {
            Console.WriteLine(Fibonacci1.Get(1));
            Console.WriteLine(Fibonacci1.Get(2));
            Console.WriteLine(Fibonacci1.Get(3));
            Console.WriteLine(Fibonacci1.Get(4));
            Console.WriteLine(Fibonacci1.Get(5));
            Console.WriteLine(Fibonacci1.Get(6));
        }
    }
}
