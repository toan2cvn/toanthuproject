using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lambda
{
    class Lambda
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Chay roi");
            while (true)
            {
                int[] scores = { 89, 67, 73, 98, 80, 75 };
                int highScoreCount = scores.Where(n => n >= 80).Count();
                int[] highScoreArray = (scores.Where(n => n >= 80)).ToArray();
                Console.WriteLine("{0} scores are greater than 80", highScoreCount);

                foreach (int n in highScoreArray)
                {
                    Console.WriteLine("Score {0} is greater than 80", n);
                }

                // Ascending sort with Anonymous
                Array.Sort(scores, delegate(int x, int y) { return x.CompareTo(y); });
                printList(scores);

                // Descending sort with Lambda
                Array.Sort(scores, (x, y) => y.CompareTo(x));
                printList(scores);

                if (Array.TrueForAll(scores, x => x > 70))
                {
                    Console.WriteLine("All members are greater than 70");
                }
                else
                {
                    Console.WriteLine("At least a member is not greater than 70");
                }

                Func<string, int, string> mixStringInt = (str, num) => string.Format("{0} {1}", str, num);
                string testStr = mixStringInt("Age: ", 23);

                Console.WriteLine(testStr);


                string choice = Console.ReadLine();
                if (choice != null)
                {
                    break;
                }
            }
        }
        static void printList(int[] numbers)
        {
            Array.ForEach(numbers, delegate(int x) { Console.Write("{0}\t", x); });
            Console.WriteLine();
        }
    }
}
