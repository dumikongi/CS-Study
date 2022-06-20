using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book.Ch10
{
    internal class p472
    {
        static void Main1(string[] args)
        {
            Console.Write("입력: ");
            string num  = Console.ReadLine(); 
            
            try
            {
                int n = int.Parse(num);
                Console.WriteLine("입력 숫자 : " + n);
            }
            catch(Exception e) 
            {
                Console.WriteLine(e.ToString()); 
                Console.WriteLine(e.Message); 
                Console.WriteLine(e.GetType);
                return;
            }
            finally
            {
                Console.WriteLine("프로그램이 종료되었습니다.");
            }


        }
    }
}
