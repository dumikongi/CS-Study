
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 * 
 *  날짜 : 2022/06/20
 *  이름 : 허락녕    
 *  내용 : 예외처리 Throw 실습하기 교재 p46
 *  
 *  
 *
 *
 */

namespace Ch07.Ch08
{

    class Box
    {

        private int width;
        private int height;
        
        public int Width { get { return width; }       // { get { return width; } set { width = value; } } 원래는 이렇게 쓰면 되지만 조건등을 붙이기 위해서 길게 썼다
            set                                        // 근데 왜 setter만하는거?? get은??
            {
                if (value > 0)
                {
                    width = value;
                }
                else
                {
                    throw new Exception("너비는 0보다 커야 합니다."); // 강제로 던진다.
                }
               
            } 
        }                                      
        public int Heigth { 
            get { return height; } 
            set 
            { 
                if (value > 0)
                {
                    height = value;
                }
                else
                {
                    throw new Exception("높이는 0보다 커야 합니다.");
                }
                 
            } 
        }

        public Box(int width, int heigth)
        {
            //this.witdh = witdh;              여기서는 왜 this. 안 붙이는거?
            //this.height = height;
            Width = width;                     // setter를 이용해서 Box의 width에 넣었다.
            Heigth = heigth;
        }

        public void Area()
        {
            Console.WriteLine(" Box 넓이 : " + width * height);
        }
    }

   

    internal class _2_Throw
    {
        static void Main1(string[] args)
        {
            try
            {
                // 강제 발생된 예외를 처리
                Box box1 = new Box(10, -10);
                box1.Area();
            }

            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
    }
}
