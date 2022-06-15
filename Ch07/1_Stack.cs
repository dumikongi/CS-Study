using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/* 
 * 날짜 : 2022/06/15
 * 이름 : 허락녕
 * 내용 : 컬렉션 스택 실습하기
 * 
 * 
 * 스택에 들어가는 걸 push 나가는 걸 pop
 * 마지막에 입력된 자료가 제일 먼저 참조된다. => 이게 무슨 말일까?? 
 * 
 *  
 */


namespace Ch07
{
    internal class _1_Stack
    {
        static void Main1(string[] args)
        {
            Stack<int> stack = new Stack<int>();     //스택에 정수를 넣겠다

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);

            while(stack.Count > 0)
            {
                Console.WriteLine(stack.Pop());          // Pop뒤에 괄호 안 하면 왜 이상한 거 뜨지? 뭔차이
            }                                                // stack은 후입선출
        }
    }
}
