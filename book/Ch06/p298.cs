using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book.Ch06
{

    
    class Box
    {
        private int width;              //widht는 변수
        public int Width                //Widht는 속성
        {
            get { return width; }
            set
            {
                if (value > 0) { width = value; }
                else { Console.WriteLine("너비는 자연수를 입력해주세요."); }
            }

        }


        private int height;
        public int Height
        {
            get { return height; }
            set
            {
                if (value > 0) { height = value; }
                else { Console.WriteLine("높이는 자연수를 입력해주세요."); }
            }
        }

        // 생성자
        public Box(int width, int height)
        {
            Width = width;
            Height = height;
        }

        // 인스턴스 메서드
        public int Area() { return this.width*this.height; }

    }






    internal class p298
    {
        static void Main1(string[] args)
        {
            Box box = new Box(10, -20);

            box.Width = -10;
        }
    }
}
