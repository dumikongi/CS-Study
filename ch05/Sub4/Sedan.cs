using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch05.Sub4
{
    internal class Sedan : Car
    {
       private int cc;

        public Sedan(string name, string color, int speed, int cc) : base(name, color, speed)
        {
            this.cc = cc;
        }


                     
        public void Show()
        {
            Console.WriteLine("=====================");
            Console.WriteLine("차량명 : "+name);
            Console.WriteLine("색상 : "+color);
            Console.WriteLine("속도 : "+speed);
            Console.WriteLine("배기량 : "+cc);
            Console.WriteLine("---------------------");
        }
    }

    
}
