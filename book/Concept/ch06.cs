using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 * 
 * 인스턴스변수 : 기본적으로 정적 수식어가 없는 클래스 변수이며 일반적으로 모든 클래스 인스턴스에서 공유됩니다. 
 *               다른 개체에서 이러한 변수는 다른 값을 가질 수 있습니다. 
 *               그것들은 클래스의 특정 개체 인스턴스에 연결되어 있으므로 인스턴스 변수의 내용은 한 개체 인스턴스와 다른 개체 인스턴스에 완전히 독립적입니다.
 *               값이 인스턴스에 따라 달라지며 이제 인스턴스 간에 공유되는 변수입니다.
 *               이러한 변수는 클래스 간에 공유할 수 없습니다. 대신, 그들은 하나의 특정 클래스에만 속합니다. 
 *               일반적으로 클래스에 필요한 데이터를 위한 메모리를 예약합니다.  
 *               일반적으로 클래스의 인스턴스가 생성될 때 생성됩니다.
 *               일반적으로 개체가 존재하는 한 값을 유지합니다.
 *               많은 복사본이 있으므로 모든 개체에는 인스턴스 변수의 고유한 개인 복사본이 있습니다.
 *               클래스 내에서 변수 이름을 호출하여 직접 액세스할 수 있습니다.
 *               이러한 변수는 static 키워드를 사용하지 않고 선언됩니다.
 *               한 개체를 통해 이러한 변수에 적용된 변경 사항은 다른 개체에 반영되지 않습니다. 



 * 클래스 변수 : 기본적으로 static으로 클래스 수준의 어느 곳에서나 선언할 수 있는 정적 변수 입니다. 
 *              서로 다른 개체에서 이러한 변수는 하나의 값만 가질 수 있습니다. 
 *              이러한 변수는 클래스의 특정 개체에 연결되지 않으므로 클래스의 모든 개체에서 공유할 수 있습니다.
 *              클래스의 특정 속성이나 속성을 정의하는 변수입니다.
 *              이러한 변수는 클래스와 해당 하위 클래스 간에 공유할 수 있습니다.
 *              일반적으로 클래스의 인스턴스 개체가 존재하지 않는 경우에도 클래스의 모든 인스턴스에 대해 단일 공유 값을 유지합니다
 *              일반적으로 프로그램이 실행되기 시작할 때 생성됩니다
 *              일반적으로 프로그램이 종료될 때까지 값을 유지합니다.
 *              클래스 변수의 복사본이 하나만 있으므로 클래스의 다른 개체 간에 공유됩니다.
 *              클래스 이름으로 호출하여 액세스할 수 있습니다.
 *              이러한 변수는 static 키워드를 사용하여 선언됩니다.
 *              한 개체를 통해 이러한 변수에 적용된 변경 사항은 다른 개체에 반영됩니다. 
 *              
 *           
 * static이라는 키워드를 붙인 변수 또는 메서드는 프로그램을 실행하는 순간에 메모리에 올라가게 된다.
 * Math.Abs()와 같은 클래스 메서드는 인스턴스화해서 메모리에 올리는 별도의 작업(new Math())없이도 사용할 수 있는 것이다. 
 * 클래스 메서드에서는 아직 메모리에 올라가지 않은 인스턴스 변수나 인스턴스 메서드를 사용할 수 없다. 
 * ->클래스 메서드에서의 인스턴스 변수 사용은 오류가 발생
 * ->클래스 메서드에서는 클래스 변수사용만 사용 가능
 * 
 * 
 *  
 * 오버로딩 : 이름은 같고 매개변수는 다른 메서드를 만드는 것, 매개변수가 다르다는 말 = 자료의 반환형이 다르다는 말
 * 
 * 접근생성자 : public, protected, private 
 * 
 * 생성자 : 무언가를 생성할 때 자동으로 호출되는 메서드
 * 생성자에서는 일반적으로 인스턴스변수를 초기화하는 일을 한다.
 * 
 * 생성자로 클래스의 인스턴스를 만들 수 없게 할 때는 private을 사용한다.
 * private을 사용하는 경우 : 정적 멤버만 가지고 있을 때, 팩토리 메서드 패턴에서 팩토리 메서드로만 인스턴스를 생성하게 하고 싶을 때
 * 정적 생성자는 일반적인 생성자 앞에 static 키워드를 붙여 생성한다.
 * 
 * static 한정자는 특정 개체가 아니라 해당 형식 자체에 속하는 정적 멤버를 선언하는 데 사용됩니다
 * static 키워드는 변수 혹은 함수 혹은 클래스가 객체(인스턴스) 단위가 아니라 클래스 단위로 생성, 사용되게 하는 키워드이다
 * 
 * 정적 생성자 : 일반적인 생성자 앞에 static 키워드를 붙인 것
 * 정적 생성자 만들 때의 제한 : 접근제한자를 쓰지 못한다. 매개변수를 사용하지 못한다. 
 * 정적 생성자는 정적 요소를 생성할 때, 또는 인스턴스를 생성하는 초기시점에 한 번만 호출된다. 
 * 
 * 
 */

namespace book.Concept
{
    internal class ch06
    {
        class Test                                // Test클래스에
        {
            public int Power(int x)               // Power 메서드를 만들었다.      // x를 넣으면
            {
                return x * x;                                                     // x*x를 반환해주는 
            }
        }

        internal class p266
        {
            static void Main1(string[] args)
            {
                Test test = new Test();                             // Test클래스의 test 인스턴스를 만들었다.
                Console.WriteLine(test.Power(9));                   // test인스턴스인
                                                                    //
                                                                    // Power메서드에 9를 넣었다

            }
        }
    }
}
