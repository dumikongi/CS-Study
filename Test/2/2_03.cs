﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._2
{
    internal class _2_03
    {
        static void Main1(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            for(int i = 0; i < 10 ; i++)
            {
                Console.Write(arr[i] + ", ");
            }

            Console.Write("\n");

            for(int j = 0; j < 5 ; j++)
            {
                int temp = arr[j];
                arr[j] = arr[9-j];
                arr[9-j] = temp;
            }
            
            foreach(int n in arr)
            {
                Console.Write(n + ", ");
            }
            
        }
    }
}
