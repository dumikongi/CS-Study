using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book.Ch05
{
    internal class p211
    {
        static void Main1(string[] args)
        {
            // 배열 생성
            int[] intArray = new int[10];
            long[] longArray = new long[10];
            string[] stringArray = new string[10];

            //요소들이 전혀 정해지지 않은 List 생성 : List<int> list = new List<int>();
            List<int> list = new List<int>() { 21, 32, 25, 68, 12 };


            list.Add(52);
            list.Add(324);
            list.Add(54);
            list.Add(2222);
            list.Add(22);

            list.Remove(25);

            foreach(var item in list)
            {
                Console.WriteLine("Count: " + list.Count + "\titem: " +item);
            }


        }
    }
}
