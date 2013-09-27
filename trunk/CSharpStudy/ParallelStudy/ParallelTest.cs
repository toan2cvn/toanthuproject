using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;
namespace ParallelStudy
{
    class ParallelTest
    {
        static void Main(string[] args)
        {
            //Parallel.Invoke(method, method);
            //Parallel.For(0, 3, method2);

            var list = new List<string>();
            for (int i = 0; i < 1000; i++)
            {
                list.Add("Yahoo" + i);
                list.Add("Google" + i);
                list.Add("Micrisoft" + i);
            }
            Stopwatch sw = new Stopwatch();

            // 並列の場合
            sw.Start();
            foreach (string elem in list)
            {
                Console.WriteLine(elem);
                //string temp = elem + "Add";
            }

            sw.Stop();
            TimeSpan timeSpan = sw.Elapsed;
            string elapsedTime = string.Format("Foreach:  {0:00}時{1:00}分{2:00}秒{3:000}ミリ秒", timeSpan.Hours, timeSpan.Minutes, timeSpan.Seconds, timeSpan.Milliseconds);

            // forechの場合
            sw = new Stopwatch();
            sw.Start();
            Parallel.ForEach(
                list,
                CreateParallelOptions(),
                (elem, loopState) =>
                {
                    Console.WriteLine(elem);
                    //string temp = elem + "Add";
                    //if (elem == "Yahoo20")
                    //{
                    //    loopState.Stop();
                    //}
                });
            sw.Stop();
            timeSpan = sw.Elapsed;
            string elapsedTime2 = string.Format("Parallel: {0:00}時{1:00}分{2:00}秒{3:000}ミリ秒", timeSpan.Hours, timeSpan.Minutes, timeSpan.Seconds, timeSpan.Milliseconds);

            Console.WriteLine(elapsedTime);
            Console.WriteLine(elapsedTime2);
            Console.ReadKey();
        }

        private static void method()
        {
            Console.WriteLine("私はだあれ?");
        }
        private static void method2(int n)
        {
            Console.WriteLine("私は{0}です。", n);
        }

        private static ParallelOptions CreateParallelOptions()
        {
            // 並列ループオプション生成
            ParallelOptions parallelOptions = new ParallelOptions();
            CancellationTokenSource cts = new CancellationTokenSource();
            parallelOptions.CancellationToken = cts.Token;
            parallelOptions.MaxDegreeOfParallelism = 5;

            return parallelOptions;
        }
    }
}
