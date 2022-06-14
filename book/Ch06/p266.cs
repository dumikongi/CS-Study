using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book.Ch06
{
    class Test
    {
        public int Power(int x)               
        {
            return x*x;
        }
    }

    internal class p266
    {
        static void Main1(string[] args)
        {
            Test test = new Test();
            Console.WriteLine(test.Power(9));

        }
    }
}
