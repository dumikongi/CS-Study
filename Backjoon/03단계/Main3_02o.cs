using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backjoon._03단계
{
    internal class _3_02
    {


        static void Main1(string[] args)
        {
            
           
                // 숫자 t를 받는다.
                int t = int.Parse(Console.ReadLine());


                // 랜덤한 t쌍의 정수 A,B를 입력받는다.
                // a, b 배열로 입력받아 나중에 출력
                int[] a = new int[t];
                int[] b = new int[t];

                
                for (int i = 0; i < t; i++)
                {
                    string[] numbers = Console.ReadLine().Split(' ');
                    a[i] = int.Parse(numbers[0]);
                    b[i] = int.Parse(numbers[1]);

                if (a[i] < 1 || a[i] > 9 || b[i] < 1 || b[i] > 9) return;

                }

                for (int i = 0; i < t; i++)
                {
                    Console.WriteLine("{0}", a[i] + b[i]);
                }
           
        }
       
      
    }
}

        /*
        class Test
        {
            public int sum(int x, int y)
            { return x + y; }
        }


        static void Main(string[] args)
        {
            String[] num1 = Console.ReadLine().Split();



            String[] num2 = Console.ReadLine().Split();

            int b1 = int.Parse(num2[0]);
            int b2 = int.Parse(num2[1]);


            String[] num3 = Console.ReadLine().Split();

            int c1 = int.Parse(num3[0]);
            int c2 = int.Parse(num3[1]);

            String[] num4 = Console.ReadLine().Split();

            int d1 = int.Parse(num4[0]);
            int d2 = int.Parse(num4[1]);

            int x = int.Parse(num[i][0]);
            int y = int.Parse(num[i][1]);

            Test test = new Test();
            Console.WriteLine(test.sum);

        }

        */




        
        
        
       
    
