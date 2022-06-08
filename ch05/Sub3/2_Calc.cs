using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch05.Sub3
{
    internal class Calc
    {

        // 싱글톤 객체 : 굳이 여러번 똑같은 걸 만들 필요가 없을 떄 데이터영역에서 하나로 만들어서 관리한다
        private static Calc instance = new Calc();       // 두번째 칼은 힙이기 때문에 이걸 데이터에 올리기 위해 static을 붙였다. 캡슐화시킴
        public static Calc Instance { get { return instance; } }    //Getter, Setter함
        private Calc() { }                                           // 결국 생성자 Calc은 Private이 되었다
        // 이 세줄은 공식이다 외워라


        public int Plus(int x, int y)
        {
            return x + y;
        }

        public int Minus(int x, int y)
        {
            return x - y;
        }

        public int Multi(int x, int y)
        {
            return x * y;
        }

        public int Div(int x, int y)
        {
            return x / y;
        }
    }
}
