using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backjoon._02단계
{
    internal class Main2_03o
    {
        static void Main1(string[] args)
        {
            int year = int.Parse(Console.ReadLine());
           

            if (year % 4 == 0 && year % 100 != 0)
            {
                Console.WriteLine("1");
            }
            else if (year % 400 == 0)
            {
                Console.WriteLine("1");
            }
            else
            {
                Console.WriteLine("0");
            }

           
        }
    }
}


/*
            if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
            {
                Console.WriteLine("1");
            }
            else
            {
                Console.WriteLine("0");
            }

          

           */
// && year % 100 == 0