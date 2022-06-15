using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/06/15
 * 이름 : 허락녕
 * 내용 : 컬렉션 Queue 실습하기
 * 
 * 큐는 선입선출
 * 
 * 
 */



namespace Ch07
{
    internal class _2_Queue
    {
        static void Main1(string[] args)
        {
            Queue<string> que = new Queue<string>();

            que.Enqueue("가");
            que.Enqueue("나");
            que.Enqueue("다");
            que.Enqueue("라");
            que.Enqueue("마");        //stack의 Push = queue의 Enqueue

           while(que.Count > 0)
            {
                Console.WriteLine(que.Dequeue());            //stack의 Pop = queue의 Dequeue
            }
        }
    }
}
