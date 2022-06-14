using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book.Ch08
{
    internal class p411
    {

        class PointClass
        {
            public int x;
            public int y;

            public PointClass(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }


        
        struct PointStruct
        {
            public int x;
            public int y;

            public PointStruct(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }

        static void Main1(string[] args)
        {
            PointClass pcA = new PointClass(10, 20);
            PointClass pcB = pcA;                           // 참조복사가 일어난다. 

            pcB.x = 100;
            pcB.y = 200;

            Console.WriteLine(pcA.x +" "+ pcA.y);
            Console.WriteLine(pcB.x +" "+ pcB.y);
            Console.WriteLine();


            PointStruct psA = new PointStruct(10, 20);
            PointStruct psB = psA;                              // 값복사가 일어난다.

            psB.x = 100;
            psB.y = 200;

            Console.WriteLine(psA.x + " " + psA.y);
            Console.WriteLine(psB.x + " " + psB.y);
            Console.WriteLine();
        }



    }
}
