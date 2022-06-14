using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book.Ch06
{
    internal class p269
    {
        class Test
        {
            public int Multi(int min, int max)
            {
                int output = 1;
                for (int i = min; i <= max; i++)
                {
                    output *= i;
                }
                return output;
            }
        }
       


        static void Main(string[] args)
        {
            Test test = new Test();
            Console.WriteLine(test.Multi(1,3));
        }
    }
}
