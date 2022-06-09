using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 
 * 생성자 : 무언가를 생성할 때 자동으로 호출되는 메서드
 * 인스턴스 생성자 : 인스턴스를 생성할 때 자동으로 호출되는 메서드
 * 생성자에서는 일반적으로 인스턴스 변수를 초기화하는 일을 한다
 * 
 */

namespace book.Ch06
{
    class Product
    {
        public string name;
        public int price;

        public Product(string name, int price)
        {
            this.name = name;
            this.price = price;            
        }
    }
    internal class p283
    {        
    }
}
