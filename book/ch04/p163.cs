using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book.ch04
{
    internal class p163
    {
        static void Main1(string[] args)
        {
            while (false)
            {
                Console.WriteLine("사실");
            }

            // while 뒤의 조건식이 참인 동안에는 뒤의 것이 반복된다. 거짓이면 한 번도 실행되지 않는다.


            int i = 0;
            int[] intArray = { 1, 2, 3, 4, 5 };                           // []는 배열이다

            while ( i < intArray.Length)
            {
                Console.WriteLine(i+1 + "번째 출력:" + intArray[i]);

                i++;
            }



        }




    }
}
