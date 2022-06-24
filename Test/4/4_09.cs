using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._4
{
    class Person
    {
        private string name;
        private int age;

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public void Hello()
        {
            Console.WriteLine("이름 : " + name);
            Console.WriteLine("나이 : " + age);
        }



    }


    class Student : Person
    {
        private string school;
        private string major;

        public Student(string name, int age, string school, string major) : base(name, age)
        {
            this.school = school; 
            this.major = major;
        }

        public new void Hello()
        {
            base.Hello();
            Console.WriteLine("학교 : "+school);
            Console.WriteLine("전공 : " +major);
        }
    }
    internal class _4_09
    {
        static void Main1(string[] args)
        {
            Person kim = new Person("김유신", 24);
            Student jang = new Student("장보고", 26, "부경대", "영문학과");

            kim.Hello();
            Console.WriteLine("------------------------");

            jang.Hello();
            Console.WriteLine("------------------------");
        }
    }
}
