using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book.Ch09
{
    internal class p444
    {
        static void Main1(string[] args)
        {
           using (StreamWriter writer = new StreamWriter(@"C:\test\test.txt"))
            {
                writer.WriteLine("안녕하세요");
                writer.WriteLine("StreamWrite 클래스를 사용하여");
                writer.WriteLine("글자를 몇 줄 입력해봅니다.");

                for (int i = 0; i < 10; i++)
                {
                    writer.WriteLine("반복문 - " + i);
                }
            }


            Console.WriteLine(File.ReadAllText(@"C:\test\test.txt"));


            using (StreamReader reader = new StreamReader(@"C:\test\test.txt"))
            {
                string line = reader.ReadLine();
                Console.WriteLine(line) ;
            }


            using (StreamReader reader = new StreamReader(@"C:\test\test.txt"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {

                    Console.WriteLine(line);
                }
            }

        }
    }
}
