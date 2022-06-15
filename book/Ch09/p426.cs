using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// 인터페이스는 실체가 아닌 규칙이므로 인스턴스르르 생성할 수 없다. 
namespace book.Ch09
{
    internal class p426
    {
        class Product : IComparable 
        {
            public string Name { get; set; }
            public int Price { get; set; }

            public override string ToString()
            {
                return Name + " : " + Price + "원";
            }

            public int CompareTo(object? obj)             //IComparable인터페이스는 CompareTo()메서드를 구현해야한다는 규약을 가지고 있다. 
            {
                return this.Price.CompareTo((obj as Product).Price);
            }

        }

        static void Main1(string[] args)
        {
            List<Product> list = new List<Product>()
            {
                new Product() { Name = "고구마", Price = 1500},
                new Product() { Name = "사과", Price = 2400},
                new Product() { Name = "바나나", Price = 1000},
                new Product() { Name = "배", Price = 3000}
            };

            list.Sort();            // Sort()메서드는 정렬을 해주는 메서드. 정렬을 어떤 기준으로 해야할지를 모른다. 그 기준을 IComparable인터페이스를 통해 구현해야한다.

            foreach(var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
