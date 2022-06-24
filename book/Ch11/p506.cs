using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 델리게이터를 활용하는 대표적은 형태는 콜백 메서드이다. 
 * 콜백 메서드는 간단하게 정의하면 매개변수로 전달하는 메서드라고 할 수 있다. 
 * 아래의 코드에서 델리게이터 PrintProcess를 선언하고 이를 콜백 메서드로 활용한다. 
 * 
 * 콜백 함수란 1. 다른 함수의 인자로써 이용되는 함수. 2. 어떤 이벤트에 의해 호출되어지는 함수.



*/

namespace book.Ch11
{
    internal class p506
    {
        class Student
        {
            public string Name { get; set; }
            public double Score { get; set; }

            public Student(string name, double score) 
            { 
                this.Name = name; 
                this.Score = score; 
            }

            public override string ToString()
            {
                return this.Name + " " + this.Score;
            }
        }

        

        class Students
        {
            private List<Student> listodStudent = new List<Student>();

            public delegate void PrintProcess(Student list);

            public void Add(Student student) 
            {
                listodStudent.Add(student);                
            }

            public void Print()
            {
                Print((student) =>
                {
                    Console.WriteLine(student);
                });
            }

            // 위 5줄을 삭제하면 아래의 'process에 해당하는 제공된 인수가 없다'고 나옴.
            public void Print(PrintProcess process)
            {
                foreach (var item in listodStudent)
                {
                    process(item);
                }
            }
        }


        class Program
        {
            static void Main1(string[] args)
            {
                Students students = new Students();
                students.Add(new Student("윤인성", 4.2));
                students.Add(new Student("연하진", 4.4));

                students.Print();
                students.Print((student) =>
                {
                    Console.WriteLine();
                    Console.WriteLine("이름 : "+student.Name);
                    Console.WriteLine("학점 : "+student.Score);

                });
                

            }
        }

    }
}
