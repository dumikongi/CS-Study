using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book.Ch11
{
    internal class p510
    { 
        public delegate void SendString(string str);

        static  void Main1(string[] args)
        {
            SendString sayHello, sayGoodbye, greet, halo;

            sayHello = Hello;
            sayGoodbye = Bye;
            halo = sayHello + sayGoodbye;

            halo("윤인성");
           

            Console.WriteLine();

            halo -= sayGoodbye;

            halo("윤인성");


           
        }

        public static void Hello(string str)
        {
            Console.WriteLine("안녕하세요. " + str + "씨...!");
        }

        public static void Bye(string str)
        {
            Console.WriteLine("안녕히 가세요. " + str + "씨...!");
        }


    }
}
