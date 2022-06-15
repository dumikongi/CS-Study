using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 * 인터페이스 내부에는 클래스 내부에 넣을 수 있었던 인스턴드 메서드, 속성을 넣을 수 있다. 
 * 하지만 내부 구현을 입력할 수 없다. 더 자세하게 뭔가를 더 적어넣을 수 없다.
 * 인터페이스를 상속받은 클래스에서 내부 구현을 입력한다. 
 * 인터페이스를 구현한 클ㄹ스는 인터페이스를 상속받게 된다. 따라서 다형성을 구현할 수 있다.
 */

namespace book.Ch09
{
    interface IBasic
    {
        int TestInstancdMethod();             
        int TestProperty { get; set; }        
    }
}
