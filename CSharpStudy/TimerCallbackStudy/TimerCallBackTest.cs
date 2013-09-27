using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
namespace TimerCallbackStudy
{
    public class TimerCallBackTest
    {
        private static ManualResetEvent Event = new ManualResetEvent(true);

        public string sss { get; set; }

        public static void Main(string[] args)
        {
            TimerCallBackTest test = new TimerCallBackTest();

            TimerCallback timerCallBack = new TimerCallback(test.PrintTime);
            Timer timer = new Timer(timerCallBack, "PrintTime Method", 0, 1000);
            test.WorkWithParallel();
            //TimerCallback timerCallBack2 = new TimerCallback((string)GetString);
            //Timer timer2 = new Timer(timerCallBack2, "Toan", 0, 1000);

            //test.WorkWithParallel();
            //Console.WriteLine(test.sss);
            Console.ReadKey();
        }
        public void PrintTime(object state)
        {
            Console.WriteLine("Time is: {0}, Parameter is: {1}", DateTime.Now.ToLongTimeString(), state.ToString());
            sss = DateTime.Now.ToLongTimeString();

            if (sss.CompareTo("13:42:50") == 0)
            {
                Event.Reset();
            }
            if (sss.CompareTo("13:43:10") > 0)
            {
                Event.Set();
            }
        }

        public string GetString(object state)
        {
            return state.ToString() + " Done!";
        }

        public void WorkWithParallel()
        {
            var list = new List<string>();
            for (int i = 0; i < 10; i++)
            {
                list.Add("Yahoo" + i);
                list.Add("Google" + i);
                list.Add("Micrisoft" + i);
            }

            // 並列の場合
            foreach (string elem in list)
            {
                Event.WaitOne();
                Console.WriteLine(elem);
                Thread.Sleep(1000);
            }

            // forechの場合

            //Parallel.ForEach(
            //    list,
            //    CreateParallelOptions(),
            //    (elem, loopState) =>
            //    {
            //        Event.WaitOne();
            //        Console.WriteLine(elem);
            //        Thread.Sleep(1000);
            //        //string temp = elem + "Add";
            //        //if (elem == "Yahoo20")
            //        //{
            //        //    loopState.Stop();
            //        //}
            //    });
        }

        private ParallelOptions CreateParallelOptions()
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