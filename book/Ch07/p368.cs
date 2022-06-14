using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * sealed를 클래스 앞에 쓰면 상속해서 쓰지 마라는 의미가 되며
 * sealed를 메서드 앞에 쓰면 이 다음부터는 오버라이딩하지 말라는 뜻
 * 
 * abstract를 클래스 앞에 쓰면 무조건 상속해서 쓰라는 의미
 * abstract class Parent 하게 되면 Parent parent = new Parent(); 오류 발생
 * abstract를 사용한 클래스는 인스턴스로 만들 수 없다.
 * 
 * abstract 키워드를 메서드에 적용할 때는 반드시 클래스에도 abstract키워드 적용해야 한다. 
 * abstract 메서드가 되면 중괄호 없이 ();로 끝낸다. 어차피 상속해서 사용할 것이므로.
 * 
 * 
 * 
 * 
 * 
 */

namespace book.Ch07
{
    internal class p368
    {
        abstract class Parent
        {
            public abstract void Test();
        }
        
        class Child : Parent
        {

            public override void Test() { }            // 여기서 override해줘야 위의 Child에서 빨간 줄이 없어진다.
        }                                         // 본래 override 키워드를 사용하려면 부모의 해당 메서드에는 virtual 키워드가 적용되어야 한다. 
    }                                             // 하지만 지금의 경우에는 버츄얼을 쓰면 오히려 오류발생. 
}                                                  // abstrac했으니 (반드시 오버라이딩 하라는 것이므로) virtual 쓰지 말라 
