using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch04
{
    internal class p187
    {
        static void Main1(string[] args)
        {
            int x = 1;
            while( x < 50)
            {
                // 화면을 지우고 커서를 이동하게
                Console.Clear();
                Console.SetCursorPosition(x, 5);


                // 출력한다
                if (x % 3 == 0)
                    Console.WriteLine("___@");
                else if (x % 3 == 1)
                    Console.WriteLine("__^@");
                else
                    Console.WriteLine("^__@");

                Thread.Sleep(1000);
                x++;


            }
        }
    }
}
