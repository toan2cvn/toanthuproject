using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ParallelLock
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> request = new Dictionary<int, string>();

            for (int i = 0; i < 100; i++)
            {
                request.Add(i, i.ToString());
            }

            var ids = request.Values.ToList();
            bool chk = false;
            int count = 0;
            int count2 = 0;

            Parallel.ForEach(ids, CreateParallelOptions(100), t =>
            {
                lock (t)
                {
                    if (t.CompareTo(99.ToString()) >= 0 && !chk)
                    {
                        Thread.Sleep(1000);
                        if (!chk)
                        {
                            count++;
                        }

                        chk = true;
                        count2++;
                    }

                    Console.WriteLine(t +"\t"+ chk);
                }
            });

            Console.WriteLine(string.Format("done count = {0}/{1}", count, count2));
            Console.Read();
        }

        private static ParallelOptions CreateParallelOptions(int numThread)
        {
            // 並列ループオプション生成
            ParallelOptions parallelOptions = new ParallelOptions();
            CancellationTokenSource cts = new CancellationTokenSource();
            parallelOptions.CancellationToken = cts.Token;
            parallelOptions.MaxDegreeOfParallelism = numThread;

            return parallelOptions;
        }
    }
}
