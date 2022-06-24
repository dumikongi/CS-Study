using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 델리게이트는 한마디로 말해서 대리자라고 말할 수 있습니다. 
 * 즉, 대신 일을 해주는 녀석이라고 할 수 있겠죠? 다른 말로 해서는 메소드 참조를 포함하고 있는 영역이라고 말할 수 있습니다. 
 * 선언 형식을 보아하니, 델리게이트가 메소드같이 생겼죠? 
 * 델리게이트는 위에서 말한 대로, 메소드의 참조를 포함합니다. 
 * '메소드를 참조한다니, 그럼 메소드를 매개변수로 넘길 수 있다는 말인가요?'
 * 네 맞습니다. 델리게이트를 이용해서 메소드를 넘겨줄 수 있습니다. 
 * 델리게이트는 메소드를 참조 하는 것이고, 참조하는 메소드가 달라진다면 델리게이트 역시 달라집니다. 
 * (한가지 주의하실 것이 있다면, 매개변수의 데이터 형식과 반환형은 참조할 메소드의 매개변수의 데이터 형식과 반환형에 맞추어야만 합니다. 개수 역시도.)
 * 
 * 
 * - delegate는 함수(메서드)를 담을 수 있는 타입이다.
 * - 타입이기 때문에 메서드의 매개변수나 리턴타입 같은 곳에도 delegate타입을 선언 할 수 있다.
 * - 델리게이트에 메서드를 여러개 담을 수 있다.
 * 
 * 델리게이트 = 함수(메서드)를 담을 수 있는 타입 = 메소드를 참조 하는 것
 * 

 
 
 */


namespace book.Concept
{
    delegate int PDelegate(int a, int b); //(1)


    internal class Delegate    
    {
        static int Plus(int a, int b) //2
        {
            return a + b;
        }

        static void Main1(string[] args)
        {

        // pd1라는 변수를 (1)에서 정의한 Delegate형으로 정의한다.
        // 그리고, 그 pd1에 (2)에서 정의한 Plus라는 함수에 대입한다.
        // 이러한 것이 Delegate이다.

            PDelegate pd1 = Plus;
            PDelegate pd2 = delegate (int a, int b)
            {
                return a / b;
            };
           


            Console.WriteLine(pd1(5, 10));
            Console.WriteLine(pd2(10, 5));
        }
    }
}

/*코드를 보시면 9행에 PDelegate라는 델리게이트가 보이죠? 
매개변수 부분에는 int형 매개변수 a, b를 명시해주었습니다. 
13~16행에서는 Plus란 메소드가 정의되었습니다. 

이제부터 자세히 보셔야 합니다. 20행을 먼저 봅시다. Plus 메소드 자체를 델리게이트에 집어넣고 있는것 같죠? 
Plus 메소드와 연결하여 대리자를 인스턴스화 합니다. 이제부터 델리게이트 pd1은 Plus 메소드를 참조하게 됩니다. 
26행을 보시면 Plus 메소드를 쓰듯, a와 b를 더해서 값을 반환합니다. 

21행을 보시면 아무 이름이 없는 메소드를 델리게이트에 집어넣습니다. 별도로 메소드를 만들지 않았죠? 
이런 무명 메소드의 사용은 한번 사용하면 불필요해지는 메소드를 만들때도 사용되는 등, 매우 유용합니다. 
27행도 26행과 마찬가지로 pd1처럼 사용할 수 있습니다.
 */ 