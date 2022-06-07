using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book.ch04
{
    internal class p159
    {
        static void Main1(string[] args)
        {
            int[] intArray = {1,2,3,4,5};

            intArray[0] = 15;


            Console.WriteLine(intArray[0]);
            Console.WriteLine(intArray[3]);
            Console.WriteLine(intArray.Length);
            //  Console.WriteLine(intArray[9]); 10번째 원소는 없으므로 출력 x
        }
    }
}
