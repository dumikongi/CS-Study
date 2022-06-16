using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._3
{
    
    abstract class Shape
    {
        public abstract void Draw();
    }

    class Triangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("삼각형 그리기...");
        }
    }

    class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("원 그리기...");
        }
    }


    internal class _3_09
    {
        static void Main1(string[] args)
        {
            _3_09 i = new _3_09();

            Circle c = new Circle();
            Triangle t = new Triangle();

            i.D(c);
            i.D(t);           
        }
        public void D(Shape s) { s.Draw(); }



    }
    
}
