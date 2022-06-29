using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backjoon._04단계
{
    internal class _04
    {
    }
}
        /*
        static void Main1(string[] args)
        {
            List<> numbers = new List();
            List<> answer = new List();

            for (int i = 0; i < 10; i++)
            {
                numbers.Add(int.Parse(ReadLine()) % 42);
            }
            for (int i = 0; i < numbers.Count - 1; i++)
            {
                for (int j = i + 1; j < numbers.Count; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        continue;
                    }
                    else
                    {
                        if (!answer.Contains(numbers[i]))
                        {
                            answer.Add(numbers[i]);
                        }
                    }
                }
            }
            if (!answer.Contains(numbers[^1]))
            {
                answer.Add(numbers[^1]);
            }
            Console.WriteLine(answer.Count); //나머지
        }
   */