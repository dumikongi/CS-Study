using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book.Ch08
{

   
    internal class p408
    {
        struct Point
        {
            public int x;
            public int y;
            public string testA;
            public string testB;

            public Point(int x, int y)
            {
                this.x = x;
                this.y = y;
                this.testA = "초기화";
                this.testB = "초기화";
            }

            public Point(int x, int y, string test)
            {
                this.x = x;
                this.y = y;
                this.testA = test;
                this.testB = test;
            }
        }


        static void Main1(string[] args)
        {
            Point p1 = new Point();
            Console.WriteLine(p1.x);
            Console.WriteLine(p1.y);
            Console.WriteLine(p1.testA);
            Console.WriteLine(p1.testB);
        }
        
    }
}
