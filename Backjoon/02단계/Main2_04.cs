using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backjoon._02단계
{
    internal class Main2_04
    {
        static void Main1(string[] args)
        {
            

            string num1 = Console.ReadLine();
            string num2 = Console.ReadLine();
            
            int n1 = int.Parse(num1);
            int n2 = int.Parse(num2);

            if (n1 < -1000 || n1 > 1000 || n1 ==0 ) return;
            else if (n2 < -1000 || n2 > 1000 || n2 == 0) return;

            if (n1 > 0 && n1 <= 1000)
            {
                if (n2 < 0 && n2 >=-1000)
                { Console.WriteLine("4"); }
                else if (n2 > 0 && n2 <= 1000)
                { Console.WriteLine("1"); }
            }
            else if( n1 < 0 && n1 >= -1000)
            {
                if (n2 < 0 && n2 >= -1000)
                {
                    Console.WriteLine("3");
                }
                else if (n2 > 0 && n2 <= 1000)
                {
                    Console.WriteLine("2");
                }
            }


        }
       
    }
}
