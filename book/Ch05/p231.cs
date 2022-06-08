using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book.Ch05
{
    
    internal class p231
    {
        class Student
        {
            public string name;
            public string id;
            public int age;
            public int height;
            public int weight;
            public DateTime birthday;

            // 인스턴트 변수만 가지고 있는 클래스이다. 모델 클래스라고 부름.
            // 추상화 : 프로그램에서 사용되는 핵심적인 부분을 추출하는 것
        }

        static void Main1(string[] args)
        {
            List<Student> list = new List<Student>();

            list.Add(new Student() { name = "김인수", height = 175});
            list.Add(new Student() { name = "문준수", height = 160});
            list.Add(new Student() { name = "수영주", height = 161});
            list.Add(new Student() { name = "박주영", height = 180});
            list.Add(new Student() { name = "조민기", height = 173});
            list.Add(new Student() { name = "정민교", height = 178});
            list.Add(new Student() { name = "김서진", height = 175});

           
            /*
             * 
             * foreach 반복문으로는 내부의 리스트에 추가 또는 제거가 불가능 
            foreach(var small in list)
            {
                if (small.height < 158)
                {
                    list.Remove(small);
                }
                
            }
            */


            /*
             * 
             * for 반복문을 사용하면 실행은 되지만 실행결과가 제대로 나오지 않는다.
             * 요소가 제거되면서(학생 한명이 제거되면서) 
             * 인덱스가 앞으로 하나씩 밀리면서 생략하는 일이 발생하기 때문이다.(2번학생이 제거되면서 3번학생이 2번이 되어 검사를 넘어가게 됨)
             * 그래서 역 for 반복문을 사용한다.
             * 
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].height < 170)
                {
                    list.RemoveAt(i);
                }
            }

            */

            for(int i = list.Count - 1; i >= 0; i--)      // -1이 있는 이유 : list.count는 7이다. list[], 안에 들어가는 수는 0부터 시작하므로 1을 빼야한다.
            {
                if (list[i].height < 170)
                {
                    list.RemoveAt(i);
                }
            }



            foreach (var small in list)
            {
                Console.WriteLine("170이상인 학생 : " + small.name + " " + small.height);
            }
            
        }
    }
}
