using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._3
{
    class Rent
    {
        public void Payment()
        {
            Console.WriteLine("임대료를 받습니다.");
        }        
    }

    class Landload : Rent
    {
        public void GetMoney()
        {
            Console.WriteLine("건물주 입니다.");
            Payment();
        }
    }


    internal class _3_06
    {
        static void Main1(string[] args)
        {
            Landload master = new Landload();
            master.GetMoney();
            
            // Rent.Payment(); 출력 안 된다.
            
            /*
            Rent rent = new Rent();
            rent.Payment();  요렇게 두 줄 쓰면 출력 된다.
            */
        }
    }
}
