using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 인터페이스는 약간 국제규격 같은 느낌

namespace Ch06.Sub2
{
    internal interface IRemoteControl           // 인터페이스는 앞에 I를 붙여줘라,
                                                // 인터페이스에는 추상메서드만 선언된다
    {
        public abstract void PowerOn();              // 인터페이스에서는 void 생략 가능
        public abstract void PowerOff();

        public void ChUp();                 // abstrac 생략
        public void ChDown();

        public void SoundUp();
        public void SoundDown();

        // 기능만 선언되어있으므로 클래스에서 구현해야한다.

    }
}
