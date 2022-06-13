using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch06.Sub2
{
    internal class SamsungRemocon : IRemoteControl
    {
        public void ChDown()
        {
            Console.WriteLine("삼성 채널 다운...");
        }

        public void ChUp()
        {
            Console.WriteLine("삼성 채널업...");
        }

        public void PowerOff()
        {
            Console.WriteLine("삼성 파워오프...");
        }

        public void PowerOn()
        {
            Console.WriteLine("삼성 파워온...");
        }

        public void SoundDown()
        {
            Console.WriteLine("삼성 사운드다운...");
        }

        public void SoundUp()
        {
            Console.WriteLine("삼성 사운드업...");
        }
    }
}
