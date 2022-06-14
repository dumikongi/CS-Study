using Ch06.Sub2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/06/13
 * 이름 : 허락녕
 * 내용 : 인터페이스 실습하기 교재 9단원
 *
 * 인터페이스 : A와 B의 교두보의 역할을 한다. 따라서 A,B의 결합도가 낮아진다. 결합도가 낮아진다는 것은 좋은 것이다. 
 * - 클래스 간에 공통의 통일된 표준규격을 통해 클래스구조를 설계하는 문법
 * - 인터페이스를 활용하여 다중 상속을 구현
 * - 인터페이스를 활용해서 객체간 결합도를 완화하는 효과를 갖는다(다형성)
 *
 */
 




namespace Ch06
{
    internal class _2_Interface
    {
        static void Main1(string[] args)
        {


            // 인터페이스로 공동 클래스구조를 설계한다
            IRemoteControl      lg = new LGRemocon();                   // 다형성을 위해서 LGRemocon이 아니라 IRemoteControl을 사용
            IRemoteControl samsung = new SamsungRemocon();

            lg.PowerOn();
            lg.ChDown();
            lg.SoundDown();
            lg.SoundUp();



            // 인터페이스를 활용한 다중 상속
            // 상속과 인터페이스를 둘 다 할 수 있다, internal class TV : Internet, IComputer 

            TV tv = new TV();
            tv.PowerOn();
            tv.Booting();
            tv.Access();




            
            // 인터페이스를 활용한 결합도 완화 ,  Bulb, Cable, ISocket

            Bulb bulb2 = new Bulb();
            // Cable cable = new Cable(bulb);              // bulb : 초기화하기 위해서 괄호 안에 적었다
            ISocket socket = new Cable(bulb2);              // Cable을 써도 되지만이렇게 써줘야 인터페이스를 활용한 것이 된다.

            socket.SwitchOn();   
            socket.SwitchOff();   





        }
    }
}
