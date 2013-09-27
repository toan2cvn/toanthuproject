using System;
using System.IO;
using System.Net;
using System.Text;

namespace HttpRequest
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string url = @"http://ameblo.jp/moerufx/entry-10841465455.html";
                string proxyUrl = "http://moody01.sakura.ne.jp/";
                string u = string.Format("{0}moody.php?id=nrpG9yT6iEWi&url={1}", proxyUrl, url);
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.Method = "GET";
                request.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/535.7 (KHTML, like Gecko) Chrome/16.0.912.75 Safari/535.7";
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                Console.WriteLine(response.StatusCode.ToString());
                Console.WriteLine(response.Headers.ToString());
                using (StreamReader streamReader = new StreamReader(response.GetResponseStream(), Encoding.GetEncoding(response.CharacterSet)))
                {
                    // 1回ソースの最後まで読み込み
                    string allSource = streamReader.ReadToEnd();
                    using (StreamWriter streamWriter = new StreamWriter("source.html", false, Encoding.GetEncoding(response.CharacterSet)))
                    {
                        streamWriter.Write(allSource);
                        streamWriter.Close();
                    }
                    streamReader.Close();
                }
            }
            catch (WebException ex)
            {
                Console.WriteLine(((HttpWebResponse)ex.Response).StatusCode.ToString());
            }

            Console.ReadKey();
        }
    }
}
