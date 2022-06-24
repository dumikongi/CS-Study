using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book.Ch11
{
    internal class p496
    {

        /* 인터페이스를 이용한 정렬
        class Product : IComparable

        {
            public string Name { get; set; }
            public int Price { get; set; }

            public int CompareTo(object? obj)
            {
                return this.Name.CompareTo((obj as Product).Name);
            }
        }

        static void Main(string[] args)
        {
            List<Product> list = new List<Product>()
            {
                new Product() { Name = "사과", Price = 4300 },
                new Product() { Name = "고구마", Price = 400 },
                new Product() { Name = "감자", Price = 500 }
            };


            list.Sort();

            foreach ( var item in list)
            {
                Console.WriteLine(item.Name + " : " + item.Price);
            }

        }
        */


        /* Sort() 메서드의 매개변수로 메서드 전달
       class Product 
       {
           public string Name { get; set; }
           public int Price { get; set; }


       }

       static void Main(string[] args)
       {
           List<Product> products = new List<Product>()
           {
               new Product() { Name = "사과", Price = 4300 },
               new Product() { Name = "고구마", Price = 400 },
               new Product() { Name = "감자", Price = 500 }
           };


           products.Sort(SortWithPrice);


           foreach(var item in products)
           {
               Console.WriteLine(item.Name + " : " + item.Price);
           }

       }


       static int SortWithPrice(Product a, Product b)
       {
           return a.Price.CompareTo(b.Price);
       }
       */



        /* 무명 델리게이터 기본을 이용한 정렬
        class Product 
        {
            public string Name { get; set; }
            public int Price { get; set; }

           
        }

        static void Main(string[] args)
        {
            List<Product> products = new List<Product>()
            {
                new Product() { Name = "사과", Price = 4300 },
                new Product() { Name = "고구마", Price = 400 },
                new Product() { Name = "감자", Price = 500 }
            };


            products.Sort(delegate (Product a, Product b)
            {
                return a.Name.CompareTo(b.Name);
            });

            foreach(var item in products)
            {
                Console.WriteLine(item.Name + " : " + item.Price);
            }

        }
        */


        class Product
        {
            public string Name { get; set; }
            public int Price { get; set; }


        }

        static void Main1(string[] args)
        {
            List<Product> products = new List<Product>()
            {
                new Product() { Name = "사과", Price = 4300 },
                new Product() { Name = "고구마", Price = 400 },
                new Product() { Name = "감자", Price = 500 }
            };

            products.Sort((a, b) => a.Price.CompareTo(b.Price)); // 아래 세 줄을 더 요약


            /*
            products.Sort((a, b) => 
            {
                return a.Name.CompareTo(b.Name);
            });
            */


            foreach (var item in products)
            {
                Console.WriteLine(item.Name + " : " + item.Price);
            }

        }







    }
}
