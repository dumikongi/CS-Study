using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book.Ch10
{
    internal class p471
    {
        static void Main1(string[] args)
        {
            Console.Write("입력 : ");
            string num = Console.ReadLine();

            try
            {
                int index = int.Parse(num);
                Console.WriteLine("입력 숫자 :" +index);
            }
            catch (Exception e)
            {
                Console.WriteLine("예외가 발생했습니다.");
                Console.WriteLine(e.Message);
                Console.WriteLine(e.GetType());
                return;                        // 여기서 코드를 종료한다. return키워드
            }

            Console.WriteLine("프로그램이 종료되었습니다.");

           
        }
    }
}
