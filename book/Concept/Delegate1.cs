using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book.Concept
{
    internal class Delegate1
    {
        // 아까와 동일하게 Delegate형의 변수를 선언한다. 
        // 함수의 인수로는 길이를 세고 싶은 대상 문자열을, 반환값으로는 문자열의 길이를 지정할 것이므로
        // 인수는 string, 리턴값은 int형으로 한다. 정의는 아래와 같이 한다.
        public delegate int Delegate(string s); // (1)

        static void Main1(string[] args)
        {
            // (1)에서 정의한 Delegate형의 변수countString를 정의한다.
            // 그리고 변수countStirng에, (2)에서 정의한 변수countString를 대입한다.
            Delegate countString = CountString;

            // 변수countString를 실행하면, 함수CountString가 실행되어
            // hoge의 문자열의 길이가 표시된다.
            Console.WriteLine(countString("hoge"));

            Console.ReadLine();
        }

        static int CountString(string s) // (2)
        {
            return s.Length;
        }
        
    }
}
