﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._1
{
    internal class _1_01
    {
        static void Main1(string[] args)
        {
            char var1 = 'A';
            int var2 = 100;
            long var3 = 2147483648L;
            float var4 = 3.14f;
            double var5 = 3.14159;
            bool var6 = true;
            bool var7 = false;                  // 불까지는 스택에 쌓인다
            string var8 = "hello";
            string var9 = null;                 // 널은 참조변수, 객체다, string 대신 object도 가능

            Console.WriteLine("var1 : " + var1);
            Console.WriteLine("var2 : " + var2);
            Console.WriteLine("var3 : " + var3);
            Console.WriteLine("var4 : " + var4);
            Console.WriteLine("var5 : " + var5);
            Console.WriteLine("var6 : " + var6);
            Console.WriteLine("var7 : " + var7);
            Console.WriteLine("var8 : " + var8);
            Console.WriteLine("var9 : " + var9);



        }
    }
}