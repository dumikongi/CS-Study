using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 그렇다면 언제 Delegate를 사용하는 것일까? 
 * 주로 이용되는 예의 하나로는 콜백 함수가 있다. 
 * 콜백함수란, 무언가의 처리가 끝난 후에, 호출하고 싶은 처리를 의미하는 것으로, 
 * 비동기 처리의 종료 통지등에 사용되는 경우가 많다.
 * 여기에서는 "Hello!'라는 문자열을 표준 출력으로 표시한 후에 
 * 어떠한 처리를 실행하는 콜백함수를 Delegate로써 정의해보도록 하자. 
 * 아래의 예는 "Hello!"라는 표준 출력하는 함수
 * 함수의 콜백 함수로 "How are you?"를 표시하는 함수를 정의하고자 한다. 
 * 
 */

namespace book.Concept
{
    internal class Delegate와_콜백함수
    {
        // 콜백함수의 Delegate형을 정의한다.
        // 여기에서는 인수와 반환값이 없는 Delegate형을 정의하고 있다.
        public delegate void Callback(); // (1)

        static void Main1(string[] args)
        {
            // (1)에서 정의한 Delegate형의 변수 sayHowAreYou를 정의한다.
            // 여기서 (2)에서 정의한SayHowAreYou함수를 대입한다.
            Callback sayHowAreYou = SayHowAreYou;

            // 콜백함수를 대입한 Delegate형의 변수를
            // SaySomethingAfterHello함수((3)에서 정의)의 인수로 하여 실행한다.
            SaySomethingAfterHello(sayHowAreYou);
            //Delegate형의 변수를 메서드에 대입할 수 있다.

            Console.ReadLine();
        }

        // 콜백함수다. (3)에서 정의한SaySomethingAfterHello함수의
        // 마지막에 실행한다.
        static void SayHowAreYou() // (2)
        {
            Console.WriteLine("How are you?");
        }

        // 콜백 함수를 실시하는 함수이다. Hello!!라고 표준 출력된 뒤에
        // 이 함수의 변수로 지정된 콜백함수가 실행된다.
        static void SaySomethingAfterHello(Callback callback) // (3)
        {
            Console.WriteLine("Hello!!");
            callback();
        }
    }
    //  "Hello!"의 표준 출력 후를, Delegate형의 변수를 사용하여 외부에서 부터 주입하는 것이 가능하다. 
}
