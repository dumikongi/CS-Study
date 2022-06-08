using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch04
{
    internal class p183
    {
        static void Main1(string[] args)
        {
            string input = "감자 고구마 가자 가자미";

            
            string[] inputs = input.Split(new char[] { '자' });

            // Console.WriteLine(inputs); 여기에서 잘려진 것들을 보려면 어떻게 하는거지? 배열을 보려면?

            foreach (var elem in inputs)
            {
                Console.WriteLine(elem);
            }

            /*
            string[] inputs = input.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            */


        }
    }
}
