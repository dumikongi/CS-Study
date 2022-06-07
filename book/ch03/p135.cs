using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book.ch03
{
    internal class p135
    {
        static void Main1(string[] args)
        {

            if (DateTime.Now.Hour < 11)
            {
                Console.WriteLine("아침 시간");
            }

            else if(DateTime.Now.Hour < 15)
            {
                Console.WriteLine("점심 시간");
            }
            else
            {
                Console.WriteLine("저녁 시간");
            }
        }
    }
}
