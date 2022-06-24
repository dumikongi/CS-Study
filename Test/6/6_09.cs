using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._6
{
    internal class _6_09
    {
        static void Main1(string[] args)
        {
            string server = "127.0.0.1";
            string port = "3306";
            string username = "    ";
            string password = "    ";
            string database = "   ";

            Console.WriteLine("**************************");
            Console.WriteLine("데이터 매니저 프로그램 v1.0");
            Console.WriteLine("**************************");


            while(true)
            {
                string strConn = $"server = {server}";
                strConn += $"port = {port};";
                strConn += $"username = {username};";
                strConn += $"password = {password};";
                strConn += $"database = {database};";

                MySqlConnection conn = new MySqlConnection(strConn);

                Console.WriteLine("종료:0, 입력:1, 전체조회:2");
                Console.Write("선택 : "  );

                int answer = int.Parse(Console.ReadLine());


                if (answer == 0)
                {
                    break;
                }

                else if (answer == 1)
                {
                    Console.Write("아이디 : ");
                    string uid = Console.ReadLine();

                    Console.Write("이름 : ");
                    string name = Console.ReadLine();

                    Console.Write("휴대폰 : ");
                    string hp = Console.ReadLine();

                    Console.Write("나이 : ");
                    string 
                        
                        
                        age = Console.ReadLine();

                }

            }
        }
    }
}
