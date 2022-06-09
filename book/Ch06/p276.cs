using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// 이름은 같고 매개변수는 다른 메서드를 만드는 것


namespace book.Ch06
{
    internal class p276
    {
        class MyMath
        {
            public static int Abs(int input)
            {
                if (input < 0) { return -input; }
                else { return input; }
            }

            public static double Abs(double input)
            {
                if (input < 0) { return -input; }
                else { return input; }
            }

            public static long Abs(long input)
            {
                if (input < 0) { return -input; }
                else { return input; }
            }
        }

        static void Main1
            
            (string[] args)
        {
            Console.WriteLine(MyMath.Abs(-13.8546));
        }
    }
}
