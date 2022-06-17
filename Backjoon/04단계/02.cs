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
            string[] num = Console.ReadLine().Split();

            int n1 = int.Parse(num[0]);
            int n2 = int.Parse(num[1]);
            int n3 = int.Parse(num[2]);
            int n4 = int.Parse(num[3]);
            int n5 = int.Parse(num[4]);
            int n6 = int.Parse(num[5]);
            int n7 = int.Parse(num[6]);
            int n8 = int.Parse(num[7]);
            int n9 = int.Parse(num[8]);

            int[] Array = new int[9] { n1,n2,n3,n4,n5,n6,n7,n8,n9};
                
                
                

            for (int i = 0; i < Array.Length; i++)
            {
                if (Array[i] > Array[i + 1])
                {
                    Array[i] = Array[i + 1];
                }

                else
                {
                    continue;
                }

            }

            Console.WriteLine(Array[0]);
        }
        

        
    }
}
