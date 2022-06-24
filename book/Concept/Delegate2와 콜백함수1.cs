using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



/*
 *  다음으로는 실제의 프로그램과 가까운 예시를 통해 움직임을 확인해보자.
 *  아래의 예시는 어떤 URL에 HTTP리퀘스트를 한 후에 돌아오는 HTTP 리스펀스에 대해 임의의 처리를 실시하는 코드이다. 
 *  이 "임의의 처리"를 Delegate를 이용해 외부에서부터 주입하고 있다. 여기서는 HTTP의 상태 코드를 반환하고 있다.
 *  
 */


  

namespace book.Concept
{
    internal class Delegate2와_콜백함수1
    {
        // HTTP리스펀스를 처리하는 함수를 정의하는 Degate형을 만든다.
        // 물론 인수로는 HTTP리스펀스를 나타내는 HttpResponseMessage를 정의한다.
        public delegate void Callback(HttpResponseMessage res); // (1)

        static void Main1(string[] args)
        {
            // (1)에서 정의한 Callback형의 Delegate인 변수callback를 정의한다.
            // 변수callback에는 (2)에서 정의한 함수 GetStatusCode를 대입한다.
            Callback callback = GetStatusCode;

            // (3)에서 정의한 함수를 호출하고 있다. 제1인수에 지정한 URL액세스에
            // 대응하는 HTTP리스펀스를 제 2인수로 지정한 콜백함수에서 처리하는 것이다.
            HttpRequest("http://www.yahoo.co.jp/", callback);

            Console.ReadLine();
        }

        // HTTP리스펀스를 처리하기 위한 콜백함수이다.
        // 여기에서는 HTTP리스펀스의 상태코드를 표준으로 출력하고 있다. 
        static void GetStatusCode(HttpResponseMessage res) // (2)
        {
            Console.WriteLine(res.StatusCode.ToString());
        }

        // 이 함수는 제 1인수로 지정한 URL에 액세스 할 때의 HTTP리스펀스에 대해,
        // 제2인수에서 지정한 Callback형의 Delegate에서 처리하는 것이다.
        async static void HttpRequest(String url, Callback callback) // (3)
        {
            using (HttpClient httpClient = new HttpClient())
            {
                // HttpClient클래스를 사용해 제1인수에 지정한URL에 액세스하여,
                // 그 HTTP리스펀스를 취득한다.
                HttpResponseMessage res = await httpClient.GetAsync(url);

                // 두 번째 파라미터로 지정한 Callback형의 Delegate에
                // 아까 취득해낸 HTTP리스펀스를 처리한다.
                callback(res);
            }
        }
       
    }
}
