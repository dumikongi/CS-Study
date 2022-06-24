using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/* 
 * 1. 함수이름 : Minus   
 * 2.함수의 반환값 : void(없음) void는 return할 값이 없기때문에 {} 몸체부분에 return을 안적어주셔됩니다.
 * 3. 함수의 매개변수값 : string s (문자열 s)
 * 
 * 지금 A클래스내의 plus라는 함수의 선언부분(public int plus(int a, int b))만 보면 각이 나와야합니다.
 * 아...이함수는 plus라는 이름이니깐 대략 더하겠다는 기능의 개발자의 의미가 있구나.
 * 아...이함수는 void가 아니니깐 일단은 return값이 존재하며 return값은 int형이구나.
 * return c; 라는것이 중요한데 이것을 보죠
 * return은 끝내겠다는 함수를 종료하겠다는 동시에 c값을 main함수에서 호출한 곳으로 던져주겠다는 뜻입니다.
 * return 이라는 것은 역시나 함수를 종료하겠다는것이고, 이와 동시에 return 뒤에적어준 변수나 값을 호출을 한곳으로 던져준다는것이지요. 이것이 함수의 기능입니다.
 *
 * 자 그럼 void라고 적힌 함수는 어떤의미일까요.void는 그냥 아무것도 없다는 뜻입니다.
 * public void print();라는 함수가 있으면 print라는 함수는 아무런값도 리턴할것이 없다는 뜻입니다.
 * 고로 호출한 메인함수에서는 그냥 호출만 할뿐이지 받을 값이 없기때문에, 주로 출력을 할때 자주 쓰입니다.
 * 
 * public void Print(int a, int b)
 * { Console.WriteLine(a+b); }      
 * // return ;     이런식으로 끝내겠다는 의미만을 위해서 return만 적어주셔도 괜찬습니다. 
 *                 값은 넣을수 없습니다 단지 호출만 되면 void이기 때문에 return [값]식으로 적어주면 error가 납니다.
 *
 * return은 언제든지 메서드 중간에 호출되어 메서드를 종료시킵니다.
 * 그리고 메서드의 결과를 메서드를 호출한 시점으로 돌려줍니다.
 * 메서드가 반환할 내용이 없는 경우에는 return을 만나면 메서드를 종료합니다.
 * 
 */



namespace book.Concept
{
    internal class Return
    {
        class A 
        {
            public int plus(int a, int b) 
            { 
                int c = a + b; 
                return c; 
            }

        }

        class program 
        {
            static void Main1()
            {
                A a = new A();
                int result = a.plus(3, 4);
                Console.WriteLine(result);
            }                 
        }        
    }
}
