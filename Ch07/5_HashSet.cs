using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 * 
 * 날짜 : 2022/06/15
 * 이름 : 허락녕
 * 내용 : 컬렉션 HashSet 실습하기
 * 
 * 
 * 
 * 
 * 
 * HashSet 
 * - 순서는 중요하지 않고 중복은 허용되지 않는 자료구조. 집합이다.
 * - 중복된 데이터를 제거하거나 이미 데이터가 존재하는지 검사할 때 사용 
 * 
 * 
 */

namespace Ch07
{
    internal class _5_HashSet
    {
        static void Main1(string[] args)
        {
            HashSet<int> set = new HashSet<int>();  

            set.Add(1);
            set.Add(2);
            set.Add(3);
            set.Add(4);
            set.Add(5);
            set.Add(2);

            Console.WriteLine("집합 원소 개수 : "+set.Count);

            foreach(int i in set) 
            {
                Console.Write(i +" ");
            }

            Console.WriteLine();

            // 집합 연산

            HashSet<int> set1 = new HashSet<int>() { 1, 2, 3, 4, 5 };
            HashSet<int> set2 = new HashSet<int>() { 2, 3, 4, 5, 6 };
            
            var result1 = set1.Intersect(set2); // 교집합 찾는 메서드, 커서 올리면 그 메서드에 필요한 반환타입을 찾을 수 있다. 하지만 var를 쓰면 알아서 변환해준다.
            var result2 = set1.Union(set2); // 합집합
            var result3 = set1.Except(set2);    // 차집합

            foreach (var item in result1)
            {
                Console.Write(item + " ");
            }




        }
    }
}
