using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ThreadTest
{
    class Test
    {
        static void Main(string[] args)
        {
            Thread t = new Thread(new ThreadStart(MethodA));
            t.Start();
            MethodB();
            Console.WriteLine();
            // Parameter aru mono
            Thread t2 = new Thread(Print);
            Student std = new Student()
            {
                Birthday = new DateTime(1989, 12, 12),
                Name = "Nguyen Dinh Toan"
            };
            t2.Start(std);

            Thread t3 = new Thread(() =>
                {
                    Thread.Sleep(1000);
                    Console.WriteLine("Thread 3 started...");
                });
            t3.IsBackground = true;
            t3.Start();
            Console.WriteLine("Main thread ending!");

            Console.ReadKey();
        }

        static void MethodA()
        {
            for (int i = 0; i < 1000; i++)
            {
                Thread.Sleep(50);
                Console.Write("0");
            }
        }

        static void MethodB()
        {
            for (int i = 0; i < 1000; i++)
            {
                Thread.Sleep(50);
                Console.Write("1");
            }
        }

        static void Print(object obj)
        {
            Thread.Sleep(1000);
            Student std = (Student)obj;
            Console.WriteLine("{0}\t{1}", std.Name, std.Birthday);
        }
    }
    class Student
    {
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
    }
}
