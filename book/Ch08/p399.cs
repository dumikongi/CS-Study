using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book.Ch08
{
    internal class p399
    {
        class SquareCaculator
        {
            public int this[int i]
            {
                get { return i*i; }
            }
        }

        class Program
        {
            static void Main1(string[] args)
            {
                SquareCaculator square = new SquareCaculator();
                Console.WriteLine(square[10]);
            }
        }
    }
}
