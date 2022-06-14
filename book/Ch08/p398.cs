using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 * 우리가 만든 클래스에서 []괄호를 사용하는 방법 : 인덱서
 * 
 */


namespace book.Ch08
{
    internal class p398
    {
        public int this[int i]
        {
            get { return i; }
            set { Console.WriteLine( i + "번째 상품 설정"); ; }
        }
    }
}
