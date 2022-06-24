using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backjoon._03단계
{
    internal class Math3_05o
    {
        /*
        static void Main(string[] args)
        {
            
            int n = int.Parse(Console.ReadLine());

            if ( n < 1 || n > 10000) return;

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i);
            }
        }
        */


        static void Main1()
        {
            //입력 첫째 줄 : 100,000보다 작거나 같은 자연수 N이 주어진다.
            int n = int.Parse(Console.ReadLine());
            StringBuilder allNumbers = new StringBuilder();

            //출력 둘째 줄 : 첫째 줄부터 N번째 줄 까지 차례대로 출력한다.
            for (int i = 1; i < n + 1; i++)
            {
                int number = i;
                allNumbers.Append(number + "\n");
            }
            Console.Write(allNumbers.ToString());
        }
    }
}
