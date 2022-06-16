using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book.Concept
{
    internal class 캡슐화__겟터__셋터
    { 
        class Box
        {
            /*
            private int witdh;                    // public으로 변수를 선언하면 외부에서 값을 마음대로 설정
            private int height;                   // private으로 변수를 선언하면 외부에서 값을 건드릴 수 없음 
                                                  // 이때 쓰는 것이 겟터와 셋터이다.  
            public Box(int witdh, int height)     // 변수를 바로 건드릴 수는 없지만 변수를 변경하는 메서드를 만들고 메서드를 호출해 변경하면 된다.
            {
                if (witdh > 0 && height > 0) { this.witdh = witdh; this.height = height; }
                else { Console.WriteLine("witdh와 height는 자연수로 초기화해주세요!"); }                    
            }

            public int Area() { return this.witdh*this.height; }
            */

            private int height;
            public int Height                          // private string name;        public string Name { get { return name; } set { name = value; } }    
            {                                          // public string Name { get; set; }
                get { return height; }
                set
                {
                    if (height > 0) { height = value; }
                    else { Console.WriteLine("자연수로 초기화해주세요."); }
                }
            }

            private int weight;
            public int Weight
            {
                get { return weight; }
                set
                {
                    if (weight > 0) { weight = value; }
                    else { Console.WriteLine("자연수로 초기화해주세요."); }
                }
            }

            Box(int height, int weight)
            {
                Height = height;
                Weight = weight;
            }
        }

    }
}
