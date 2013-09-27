using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StringCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "まみマミﾏﾐabビﾋﾞ";
            int countB = StringCount.LenB(input);

            Console.WriteLine(countB);
            Console.ReadLine();
        }
    }
}
