using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch06.Sub2
{
    internal class TV : Internet, IComputer               // TV가 인터넷을 상속받고, IComputer를 구현한다.
    {
        public void PowerOn()
        {
            Console.WriteLine("TV PowerOn...");
        }

        public void AccesssInternet()
        {
            base.Access();
        }

        public void Booting()
        {
            Console.WriteLine("TV Booting...");
        }
    }
}
