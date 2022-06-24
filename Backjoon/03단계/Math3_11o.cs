using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backjoon._03단계
{
    internal class Math3_11o
    {

        static void Main1(string[] args)
        {
            // s[0]은 수열의 A, s[1]은 정수 X
            string[] s = Console.ReadLine().Split();


            // s[0]을 이루는 수열들
            string[] q = Console.ReadLine().Split();


            StringBuilder answer = new StringBuilder();

            for (int i = 0; i < int.Parse(s[0]); i++)
            {
                // 정수 x보다 작은 숫자들을 검출
                if (int.Parse(s[1]) > int.Parse(q[i]))
                {
                    // 해당 숫자들을 answer에 공백과 함께 추가한다.
                    answer.Append(q[i] + " ");
                }
            }
            // 정답 출력
            Console.WriteLine(answer.ToString());


            /*
            static void Main(string[] args)
            {
                string[] num1 = Console.ReadLine().Split(' ');
                int n1 = int.Parse(num1[0]);
                int n2 = int.Parse(num1[1]);

                List<int> ints1 = new List<int>();


                for(int i = 0; i < n1; i++)
                {
                    string[] num2 = Console.ReadLine().Split(' ');
                    ints1.Add(int.Parse(num2[i]));
                }

                List<int> ints2 = new List<int>();


                for (int i = 0; i < n1; i++)
                {
                    if (ints1[i] < n2)
                    {
                       ints2.Add(ints1[i]);
                    }
                }

                for(int i = 0; i < ints2.Count; i++)
                {
                    Console.Write(ints2[i]);
                }
            */



            /*
             Random random = new Random();

             for(int i = 0; i < n1; i++)
             {
                 int rand = random.Next(1, 10000);
                 Console.Write(rand + " ");
             }
             */








        }
   
    }
}
