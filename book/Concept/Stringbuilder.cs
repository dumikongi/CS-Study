using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 * 문자열을 더할때 자주 쓰이는 string + string 연산과 StringBuilder 클래스의 Append 함수 연산의 차이를 비교해보자.
 

▶  내부 동작

▷ string + string : 
C#이나 Java에서 string은 값타입이 아닌 참조타입이다. 
+ 기호를 사용하여 문자열을 조합할 때 마다 새로운 string 객체가 생성이 되고 
이전의 문자열 객체는 GC(가비지 컬렉터)의 수거 대상이 된다.
+ 연산 한 번당 메모리를 하나씩 먹는다는 소리인데 
반복문으로 + 연산을 1000번 한다고 치면 1000개의 string 객체 메모리가 낭비되는 셈이다.
즉, 많은 + 연산을 실행할 수록 메모리가 낭비되고 이로 인해서 가비지 컬렉션이 자주 발생하게 되어 성능 저하를 유발할 수 있다.
 
▷ StringBuilder.Append(string) : 
StringBuilder는 문자열을 생성을 도와주는 클래스로 Append 함수를 이용해서 문자열을 이어붙일 수 있다.
+ 연산과 다른점은 문자열을 조합할 때 새로운 string 객체를 생성하지 않아 메모리 누수가 되지 않는다는 것이다.
 
▶  적용
▷ string + string : 문자열 수정 작업이 적게 일어나거나 자주 수행하지 않는 로직에서 사용할 때 적합하다.
▷ StringBuilder.Append(string) : 문자열 수정 작업이 많이 일어나거나 빈번하게 수행될 때, 
혹은 수정 작업의 횟수를 프로그램 설계 단계에서 알 수 없을 때 사용하는 것이 적합하다.

C#의 StringBuilder는 변경할 수 없는 string과 달리 변경 가능한 문자열을 나타내는데 사용하는 클래스입니다. 
string 객체는 값이 변경되면 메모리에서 이전 참조 값을 버리고 새로운 참조 값으로 변경되지만, 
StringBuilder 객체는 참조 값이 변경되지 않고 힙 메모리에서 값이 삽입, 추가, 제거됩니다. 

*/

namespace book.Concept
{
    internal class Stringbuilder
    {
        static void Main1(string[] args)
        {
            // 문자열을 더하는 방법 C#에서 문자열을 더하는 방법은 여러가지가 있지만 가장 잘 알려진 방법은 아래와 같은 방법일 것이다.
            string result1 = "hello" + "world"; // "helloworld"
            // 문자열과 문자열을 더하기 기호로 이어붙이는 방법이다. 단순하게 표현할 수 있어서 C# 이외에도 대부분의 언어들이 지원하고 있는 기능이다.

            // 두 번째로 알려진 방법은 StringBuilder 클래스의 Append 함수를 이용하여 builder 객체에 문자열을 이어붙인 후 꺼내는 방법이다.
            var builder = new StringBuilder();
            builder.Append("hello");
            builder.Append("world");
            string result2 = builder.ToString(); // "helloworld"
            //두 방법 모두 과정이 비슷하고 결과물은 동일하지만 내부 동작에서 큰 차이가 있다.
        }
    }
}
