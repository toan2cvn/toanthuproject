using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Delegate
{
    class Delegate
    {
        private delegate void sampleDelegate();
        private delegate string NewType(int num);
        private static void a()
        {
            Console.WriteLine("Day la mot method");
        }

        private static void b(sampleDelegate sample)
        {
            sample();
        }

        // new sample
        private static string DoAction(NewType funcName, int num)
        {
            return funcName(num);
        }
        private static string Convert(int num)
        {
            return string.Format("{0}", num);
        }
        
        static void Main(string[] args)
        {
            
            while (true)
            {
                Console.WriteLine("Vai ca los, vao roi!");
                b(a);

                string rs = DoAction(Convert, 20);

                string choice = Console.ReadLine();
                if (choice == "x")
                {
                    break;
                }
            }
        }

    }
}

