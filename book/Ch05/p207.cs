using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch05
{
    internal class p207
    {
        static void Main1(string[] args)
        {
            Random random = new Random();

            Console.WriteLine(random.Next(5, 75));
            Console.WriteLine(random.NextDouble()*3);
        }
    }
}
