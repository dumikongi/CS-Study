using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/06/03
 * 이름 : 허락녕
 * 내용 : 문자열 (string) 처리 실습 교재 p112
 * 
 */



namespace ch02
{
    internal class _6_String
    {
        static void Main1(string[] args)
        {
            string greeting = "Good Morning";
            Console.WriteLine("greeting : "+greeting);
            Console.WriteLine();                                //이걸 써야 한 줄 띄어진다



            //문자열 길이

            Console.WriteLine("greeting 길이 : "+greeting.Length);
            Console.WriteLine();

            //문자열 추출 원하는 번째의 문자를 추출
            Console.WriteLine("greeting[첫번째문자] : " + greeting[0]);
            Console.WriteLine("greeting[세번째문자] : " + greeting[2]);


            //indexOf 인덱스 번호를 확인하는 것
            Console.WriteLine("IndexOf 'G' : "+greeting.IndexOf('G'));
            Console.WriteLine("IndexOf \"G\" : "+greeting.IndexOf("G"));
            Console.WriteLine("IndexOf 'o' : "+greeting.IndexOf('o'));
            Console.WriteLine("IndexOf \"Mor\" : "+greeting.IndexOf("Mor"));
            Console.WriteLine("IndexOf \"in\" : "+greeting.IndexOf("in"));

            //쌍따옴표 안에서 다시 쌍따옴표를 사용하고 싶을 때, \(또는 역슬러시) 사용





            //LastindexOf 뒤에서부터 번ㅉ
            Console.WriteLine("LsatIndexof 'G' :"+greeting.LastIndexOf('G'));
            Console.WriteLine("LsatIndexof 'o' :"+greeting.LastIndexOf('o'));
            Console.WriteLine("LsatIndexof 'o' :"+greeting.LastIndexOf('o'));
            Console.WriteLine("LsatIndexof \"Mo\" :"+greeting.LastIndexOf("Mo"));
            Console.WriteLine("LsatIndexof \"ing\" :"+greeting.LastIndexOf("ing"));






            //Sutstring

            //Console.WriteLine("Substring(0, 4) : {0}", greeting.Substring(0, 4));
            //Console.WriteLine("Substring{5, 7} : {0}", greeting.Substring(5, 7));
            //Console.WriteLine("Substring{5} : {0}", greeting.Substring(5));
            //Console.WriteLine();


            //Replace
            String replaced = greeting.Replace("Morning", "Afternoon");
            Console.WriteLine("replaced : "+replaced);
            Console.WriteLine();



            //기본형 데이터를 문자열로 변환

            int    var1 = 1;
            double var2 = 2.12;
            bool   var3 = true;

            string str1 = var1.ToString();
            string str2 = var2.ToString();
            string str3 = ""+var3;                

            Console.WriteLine("str1 :"+str1);
            Console.WriteLine("str2 :"+str2);
            Console.WriteLine("str3 :"+str3);

            // 문자열 데이터를 기본형으로 변환 p115
            string s1 = "3";
            string s2 = "3.14";
            string s3 = "false";

            int r1 = int.Parse(s1);
            double r2 = double.Parse(s2);   
            bool r3 = bool.Parse(s3);

            Console.WriteLine($"r1 :{r1}");
            Console.WriteLine($"r2 : {r2}");
            Console.WriteLine($"r3 : {r3}");

        }
    }
}
