using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



/*
 * 날짜 : 2022/06/20
 * 이름 : 허락녕    
 * 내용 : 파일입출력(FileIO) 실습하기
 * 
 * 스트림 : 입출력장치와 프로그램 간 데이터 전송 통로
 * 
 * 파일입출력 :
 * - 파일(file)은 컴퓨터 저장매체(HDD)에 저장되는 데이터묶음. (파일의 종류에 따라 나눠진다)
 * - 프로그램은 데이터처리(Process)와 더불어 처리결과를 저장하기 위해 파일 입출력을 실행한다.
 * 
 * 
 *  쩜 : 참조 연산자
 */


namespace Ch07.Ch08
{
    internal class _3_File_IO
    {
        static void Main(string[] args)
        {
            /////////////////////////////////////
            /// 파일 읽기(파일 입력, Read)                   가져오는 거, 만들어진 것
            ///////////////////////////////////// 
            string path1 = "C:\\Users\\1302\\Desktop\\Sample1.txt";
            FileStream fs = null;
            StreamReader sr = null;

            try
            {
                // 스트림 생성
                fs = new FileStream(path1, FileMode.Open, FileAccess.Read);

                // 텍스트 파일 전용 보조스트림 연결
                sr = new StreamReader(fs);

                // 파일 읽기
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
           
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            

            finally
            {
                // 파일 닫기(자원해제)
                sr.Close();
                fs.Close();
            }
            




            /////////////////////////////////////
            /// 파일 쓰기(파일 출력, Write)               내보내는 것, 만드는 것
            ///////////////////////////////////// 
            string path2 = "C:\\Users\\1302\\Desktop\\Sample2.txt";
            FileStream outfs = null;
            StreamWriter sw = null;

            try
            {
                // 스트림 생성
                outfs = new FileStream(path2, FileMode.OpenOrCreate, FileAccess.Write);    // 파일이 없으니깐 오픈이 아니라 다른 걸 쓴다. 오픈오어크리에이트 니깐 덮어쓰기가 된다
                sw = new StreamWriter(outfs);

                // 파일 쓰기
                sw.WriteLine("Welcome World");
                sw.WriteLine("Welcome Korea");
                sw.WriteLine("Welcome Busan");
            }
           
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            finally
            {
                // 파일 닫기
                sw.Close();
                outfs.Close();
            }



            ////////////////////////
            /// 파일 읽기 쓰기
            /// ////////////////////
            /// finally가 필요 없는 자동처리 문법 
            string f1 = "C:\\Users\\1302\\Desktop\\Sample1.txt";
            string f3 = "C:\\Users\\1302\\Desktop\\Sample3.txt";


            // 샘플1을 복사해서 샘플 3을 만들고 있는 거다.
            try
            {
                using StreamReader reader = new StreamReader(new FileStream(f1, FileMode.Open));
                using StreamReader writer = new StreamReader(new FileStream(f3, FileMode.Create));

                string txt;

                while ((txt = reader.ReadLine()) != null)
                {
                    Console.WriteLine(txt);

                }
            }


            

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }




            Console.WriteLine("프로그램 종료...");

        }


    }
}
