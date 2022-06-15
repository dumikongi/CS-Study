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
 * 내용 : 컬렉션 ArrayList 실습하기
 * 
 * ArrayList
 * - 배열과 유사한 동적 선형 자료구조
 * - 
 * 
 * 
 * Array은 한 번 작성하면 수정이 안 된다는 단점이 있다. 그래서 지금은 ArrayList를 쓴다.
 * 데이터가 입력되면 크기가 늘어난다.
 * List는 ArrayList를 일반화시킨(제네릭했다) 자료구조로 ArrayList보다 더 나은 성능 (똑같은 자료의 크기라고 했을 때 List가 훨씬 빠르다.)
 * List는 제네릭클래스, ArrayList는 일반클래스
 * 
 * ArrayList가 아닌 List를 사용해라.
 * 
 * 
 * 
 */

namespace Ch07
{
    internal class _3_ArrayList
    {
        static void Main1(string[] args)
        {
            //ArrayList 생성
            ArrayList list1 = new ArrayList(); // 유징선언, ,using이 필요할 땐 컨트롤쩜

            // 데이터 입력  Add
            list1.Add(1);
            list1.Add(2);
            list1.Add(3);
            list1.Add(4);
            list1.Add(5);    // 크기가 미리 주어져있지 않고 Add할 때마다 배열의 크기가 계속 늘어난다

            // 데이터출력
            foreach(int n in list1)
            {
                Console.Write(n+" ");
            }

            Console.WriteLine();



            // 데이터 삽입 Insert
            list1.Insert(1, 6);     //두번째 자리에 6을 넣겠다.

            foreach (int n in list1)
            {
                Console.Write(n + " ");
            }

            Console.WriteLine();

            // 데이터 삭제 Remove, RemoveAt
            list1.Remove(6);          // 데이터 6을 제거

            foreach (int n in list1)
            {
                Console.Write(n + " ");
            }

            Console.WriteLine();

            list1.RemoveAt(0);        // 첫번째 데이터를 제거

            foreach (int n in list1)
            {
                Console.Write(n + " ");
            }

            Console.WriteLine();  

            // 다양한 형식의 데이터를 갖는 ArrayList

            ArrayList list2 = new ArrayList();

            list2.Add(100);
            list2.Add(0.12);
            list2.Add(true);
            list2.Add('A') ;
            list2.Add("Apple");

            for (int i = 0; i < list2.Count; i++)
            {
                Console.WriteLine(list2[i]);
            }

            /////////////////////////////////////////////////////////////////////
            /// List 교재 p211
            /// 

            List<int> list3 = new List<int>();    // List는 제네릭 클래스다. <>가 있으므로. 자료형을 지정할 수 있다.

            list3.Add(1);
            list3.Add(2);
            list3.Add(3);
            list3.Add(4);
            list3.Add(5);

            foreach(int n in list3)
            {
                Console.Write(n + " ");
            }

            Console.WriteLine();

            List<string> list4 = new List<string>();

            list4.Add("가나");
            list4.Add("다라");
            list4.Add("마바");
            list4.Add("사아");
            list4.Add("자차");
            list4.Add("카타");

            foreach(string name in list4)
            {
                Console.Write(name + " ");
            }

            Console.WriteLine();

            List<Apple> list5 = new List<Apple>();    // 객체 리스트

            list5.Add(new Apple("한국", 3000));             // Apple a1 = new Apple("한국" , 3000); list5.Add(a1);과 같다
            list5.Add(new Apple("미국", 2000));
            list5.Add(new Apple("일본", 1000));

            Apple a1 = list5[0];               // Console.WriteLine(list5.show()); 이건 왜 안 되는겨??
            list5[1].show();



        }
    }
}
