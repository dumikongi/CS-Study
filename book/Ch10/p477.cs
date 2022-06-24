using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book.Ch10
{
    internal class p477
    {
        static void Main1(string[] args)
        {
            Console.Write("입력 : ");
            string input = Console.ReadLine();
           

            int[] array = { 1, 2, 3, 4 };

            try
            {
                int num = int.Parse(input);
                Console.WriteLine("입력 숫자 : "+num);
                Console.WriteLine("배열 요소 : " + array[num]);
            }

            catch (FormatException e)
            {
                Console.WriteLine("FornatException 발생");
                Console.WriteLine(e.GetType() + "이 발생했습니다.");
            }

            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("IndexOutOfRangeException 발생");
                Console.WriteLine(e.GetType() + "이 발생했습니다.");

            }

        }
      

    }
}
