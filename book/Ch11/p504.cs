using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book.Ch11
{
    internal class p504
    {
        public delegate void TestDelegate();

        static void Main1(string[] args)
        {
            TestDelegate testDelegateA = TestMethod;          // 메서드 이름을 사용한 초기화 방법
            TestDelegate testDelegateB = delegate() { };      // 무명 델리게이트를 이용한
            TestDelegate testDelegateC = () => { };           // 람다를 사용한

            testDelegateA(); // 델리게이터는 일반 메서드처럼 호출할 수 있다.
            testDelegateB();
            testDelegateC();

        }


        static void TestMethod()
        {

        }
    }
}
