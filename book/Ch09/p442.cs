using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book.Ch09
{
    internal interface p442
    {
        static void Main1(string[] args)
        {
            File.WriteAllText(@"c:\test\test.txt", "문자열을 파일에 쓴다");
            Console.WriteLine(File.ReadAllText(@"c:\test\test.txt"));
        }
    }
}
