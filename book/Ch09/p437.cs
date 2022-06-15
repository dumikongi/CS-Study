using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book.Ch09
{
    internal class p437
    {
        class TestClass : IBasic
        {
            public int TestProperty { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

            public int TestInstancdMethod()
            {
                throw new NotImplementedException();
            }
        }


        static void Main1(string[] args)
        {
            IBasic basic = new TestClass();       // 제일 앞에 TestClass가 아닌 IBasic을 썼다. 다형성.
        }

    }

    
}
