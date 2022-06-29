using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backjoon._04단계
{
    internal class _2
    {
        static void Main1(string[] args)
        {
            int[] arr = new int[9];
            int max = 0;
            int num = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    arr[i] = max;
                    num = i + 1;
                }
            }

            Console.WriteLine(max);
            Console.WriteLine(num);

        }     

        
    }
}
