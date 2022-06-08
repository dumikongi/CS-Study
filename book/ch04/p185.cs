using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch04
{
    internal class p185
    {
        static void Main1(string[] args)
        {
            string[] array = { "배", "귤", "포도", "사과" };
            // Console.WriteLine(array[2]);  원소들 출력 가능
            Console.WriteLine(string.Join(" ", array));       //배열을 문자열로 바꾼 후 출력 가능
        }
    }
}
