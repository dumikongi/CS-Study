using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backjoon._04단계
{
    internal class _01
    {
        static void Main1(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            string[] s = Console.ReadLine().Split();

            for(int i = 0; i < s.Length; i++)
            {
                arr[i] = int.Parse(s[i]);
            }

            Array.Sort(arr);

            Console.WriteLine($"{arr[0]} {arr[n-1]}");
        }

    }
}




