using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/* IComparable은 비교할 때 사용하는 인터페이스로, Sort()메서드에는 필수다. 
 * 그리고 IComparable은 CompareTo()메서드를 반드시 사용해야한다. 컨트롤 쩜 누르면 자동완성 된다
 * 
 * IDisposable인터페이스는 using블록을 사용할 때에 자동으로 호출되는 규약이다. 
 * 
 * 인터페이스는 특별한 기능이 아니라 '이런 최소사항을 지켜서 만들면 나머지는 우리가 처리해주겠다'라는 규약.
 * 따라서 컨트롤쩜 눌러서 인터페이스 구현을 눌러주기만 하면 된다.
 *  
 * 
 * 
 * 
 * 
 */

namespace book.Ch09
{
    internal class p430
    {
        class Dummy : IDisposable
        {
            public void Dispose()
            {
                Console.WriteLine("Disposable() 메서드를 호출합니다.");
            }
        }

        static void Main1(string[] args)
        {
            Dummy dummy = new Dummy();
            dummy.Dispose();
        }
    }
}
