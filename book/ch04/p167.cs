using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book.ch04
{
    internal class p167
    {
        static void Main1(string[] args)
        {
            int sum = 0;
            

            for (int n = 0; n <= 100; n++)
            {
                sum += n;
            }



            Console.WriteLine("0부터 100까지의 합: " +sum);

        }
    }
}
