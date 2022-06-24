using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 * 
 * "연산하는 횟수는 제한할 필요가 없으므로, while(1)을 통해 무한반복으로 설정해놓는다." 
 * "입력한 초기값과 연산해서 나온 결과값이 다를 때까지 연산하고, 같으면 빠져나오는 if / break문 필요하다." 
 * "초기값을 저장해줄 빈 값이 필요하다."
 * 
 */


namespace Backjoon._03단계
{
    internal class Math3_14
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            if (a < 0 || a > 100) return;

            int x = a / 10;
            int y = a % 10;

            

        }
    }
}
