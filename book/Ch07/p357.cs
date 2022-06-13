using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book.Ch07
{
    internal class p357
    {
        public static int number = 10;

        static void Main1(string[] args)
        {
            int number = 20;
            Console.WriteLine(number);

            // C언어 기반의 프로그래밍 언어 대부분은 변수 이름이 겹칠 때 자신과 가장 가까운 변수를 사용하게 되어 있다. 그래서 20

            // 이처험 특정한 영역에서 이름이 겹쳐서 다른 변수를 가리는 것을 섀도잉(shadowing)이라고 한다.
        }
    }
}
