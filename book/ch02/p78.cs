using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book.ch02
{
    internal class p78
    {
        static void Main1(string[] args)
        {
            // int number = 10;
            //Console.WriteLine(3 < number < 20); 안 된다 왜냐면 3<Number가 true로 바뀌어  true <20이ㅣ 되기 때문이다

            Console.WriteLine(DateTime.Now.Hour < 3 || 8 < DateTime.Now.Hour);
            Console.WriteLine(3 < DateTime.Now.Hour && DateTime.Now.Hour < 8);
        }
    }
}
