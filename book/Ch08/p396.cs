using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/* 제네릭은 클래스 내부에서 자료형에 별칭을 지정하는 기능
 * ex) List<int> list = new List<int>();  int 자료형이 할당되는 것
 * 
 * 
 * 
 * 
 * 
 */


namespace book.Ch08
{
    internal class p396
    {

        class Wanted<T>
        {
            public T Value;
            public Wanted(T value)
            {
                this.Value = value;
            }
        }

        class Progra
        {
            static void Main1(string[] args)
            {
                Wanted<string> wantedString = new Wanted<string>("String");
                Wanted<int> wantedInt = new Wanted<int>(512552);
                Wanted<double> wantedDouble = new Wanted<double>(52.273);

                Console.WriteLine(wantedString);
                Console.WriteLine(wantedInt);
                Console.WriteLine(wantedDouble);
            }
        }
    }
}
