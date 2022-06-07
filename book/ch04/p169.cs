using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book.ch04
{
    internal class p169
    {
        static void Main1(string[] args)
        {
            long start = DateTime.Now.Ticks;
            long count = 0;

            while (start + (10000000) > DateTime.Now.Ticks)
            {
                count++;
            }

            Console.WriteLine(count + "만큼 반복했습니다.");

        
        }
    }
}
