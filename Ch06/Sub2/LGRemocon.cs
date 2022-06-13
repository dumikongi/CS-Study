using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch06.Sub2
{
    internal class LGRemocon : IRemoteControl               // 상속이 아니라 인터페이스다
    {
        public void ChDown()
        {
            Console.WriteLine("LG ChDowm...");
        }

        // 일종의 오버라이드다, 인터페이스에 있던 것들이 온다
        public void ChUp()
        {
            Console.WriteLine("LG ChUp...");
        }

        public void PowerOff()
        {
            Console.WriteLine("LG PowerOff...");
        }

        public void PowerOn()
        {
            Console.WriteLine("LG PowerOn...");
        }

        public void SoundDown()
        {
            Console.WriteLine("LG SoundDowm...");
        }

        public void SoundUp()
        {
            Console.WriteLine("LG SoundUp...");
        }
    }
}
