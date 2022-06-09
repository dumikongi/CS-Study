using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch05.Sub5
{
    internal class Animal
    {
        public virtual void Move()                  // 버츄얼 = 가상, 허상으로 실제 구현은 자식들이 한다 
        {
            Console.WriteLine("Animal Move...");
        }
    }
}
