using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book.Ch10
{
    internal class p480
    {
        static void Main1(string[] args)
        {
            try
            {
                throw new Exception();
            }

            catch (Exception exception)
            {
                Console.WriteLine("예외가 발생했습니다.");
            }
        }
    }
}
