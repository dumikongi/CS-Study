using Ch07.Sub1;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 * 날짜 : 2022/06/15
 * 이름 : 허락녕
 * 내용 : 컬렉션 HashTable, Dictionary 실습하기
 * 
 * 
 */


namespace Ch07
{
    internal class _4_HashTable
    {
        static void Main1(string[] args)
        {
            // 해쉬테이블 생성
            Hashtable table = new Hashtable();

            // K-V 형 데이터 저장 (Key - Value)
            table['A'] = "Apple";
            table['B'] = "Banana";
            table['C'] = "Cherry";

            // 데이터출력
            Console.WriteLine("table[A] : " + table['A']);
            Console.WriteLine("table[B] : " + table['B']);
            Console.WriteLine("table[C] : " + table['C']);

            // 반복문 데이터출력
            foreach(char k in table.Keys) { Console.WriteLine(table[k]); }           //("table[0] : "k +table[k]); 이런 식으로는 어떻게 만들더라


            ///////////////////////////////////////////////////////////
            ///Ditionary
            ///////////////////////////////////////////////////////////

            Dictionary<char, string> dic = new Dictionary<char, string>();        // 키타입은 char, 밸류타입은 string 

            dic['A'] = "Apple";
            dic.Add('B', "Banana");
            dic['C'] = "Cherry";


            foreach(char c in dic.Keys)           { Console.WriteLine(dic[c]); }
            foreach (string fruit in dic.Values)  { Console.WriteLine(fruit); }            //dic의 밸류값들을 fruit이라고 칭하고 그것들을 출력하라.


            // 딕셔너리 생성2
            Dictionary<int, string> people = new Dictionary<int, string>();

            // 데이터입력
            people.Add(101, "김유신");
            people.Add(102, "김춘추");
            people.Add(103, "장보고");
            people.Add(104, "강감찬");
            people.Add(105, "이순신");

            // 데이터출력
            foreach (string name in people.Values) { Console.WriteLine(name); }
            foreach (int n in people.Keys) { Console.WriteLine(people[n]); }



            ///////////////////////////////////
            /// 딕셔너리, 리스트 응용
            ///////////////////////////////////
            
            Dictionary <int, Apple> d1 =  new Dictionary<int, Apple>(); 
            Dictionary <int, Apple> d2 =  new Dictionary<int, Apple>(); 
            Dictionary <int, Apple> d3 =  new Dictionary<int, Apple>();

            d1.Add(101, new Apple("한국", 3000));         // Apple a1 = new Apple("한국", 3000);  d1.Add(101, a1); 과 같다
            d1.Add(102, new Apple("미국", 2000));
            d1.Add(103, new Apple("일본", 1000));
            
            d2.Add(201, new Apple("중국", 6000));
            d2.Add(202, new Apple("대만", 5000));
            d2.Add(203, new Apple("인도", 4000));
            
            d3.Add(301, new Apple("태국", 7000));
            d3.Add(302, new Apple("가나", 8000));
            d3.Add(303, new Apple("이란", 9000));
            
            List<Dictionary<int, Apple>> apples = new List<Dictionary<int, Apple>>();
            apples.Add(d1);
            apples.Add(d2);
            apples.Add(d3);


            // 한국 사과 출력
            Dictionary<int, Apple> d = apples[0];            // 위의 d1이라는 이름은 없어진건가
            Apple a = d[101];
            a.show();

            // 미국 사과 출력
            apples[0][102].show();                 // 꺼낼 때는 키값으로 꺼내야한다. -> 무조건?





        }
    }
}
