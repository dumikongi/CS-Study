﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book.ch03
{
    internal class p140
    {
        static void Main1(string[] args)
        {
            Console.Write("지금은 몇 월인가요: ");
            int input = int.Parse(Console.ReadLine());

            switch (input)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("겨울");
                    break;

                case 3:
                case 4:
                case 5:
                    Console.WriteLine("봄");
                    break;

                case 6:
                case 7:
                case 8:
                    Console.WriteLine("여름");
                    break;

                case 9:
                case 10:
                case 11:
                    Console.WriteLine("겨울");
                    break;

            }



        }
    }
}
