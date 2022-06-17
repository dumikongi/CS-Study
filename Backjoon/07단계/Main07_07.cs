using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backjoon._07단계
{
    internal class Main07_07
    {
        static void Main1(string[] args)
        {
            string num = Console.ReadLine();
            int n = int.Parse(num);

            if (n < 3 || n > 5000) return;

            int x = n % 5 % 3;

            if (n % 5 == 0)
            {
                Console.WriteLine(n / 5);
            }
            else if (n % 3 == 0)
            {
                Console.WriteLine(n / 3); 
            }
            else if (x == 0)
            {
                Console.WriteLine((n / 5) + (n % 5) / 3);
            }

            else
            {
                Console.WriteLine(-1);
            }
            
        }                    
   
    }
}
