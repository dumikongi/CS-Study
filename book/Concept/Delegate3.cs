using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book.Concept
{
    class Delegate3
    {
        //1. 델리게이트 정의
        public delegate void MyDelegate();

        static void Main1(string[] args)
        {
            Class1 c = new Class1();

            //2. 델리게이트 인스턴스 생성
            MyDelegate m1 = new MyDelegate(c.InstRun);
            MyDelegate m2 = new MyDelegate(Class1.StaticRun);

            Console.ReadLine();

            //3. 델리게이트 실행
            m1();
            m2();
        }
    }

    class Class1
    {
        public void InstRun()
        {
            Console.WriteLine("InstRun");
        }

        public static void StaticRun()
        {
            Console.WriteLine("StaticRun");
        }
    }
}
