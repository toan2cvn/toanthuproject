using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassAndObject
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal a = new Animal();
            Console.WriteLine(a.Sound());

            Animal b = new Horse();
            Console.WriteLine(b.Sound());

            Animal c = new Pig();
            Console.WriteLine(c.Sound());

            Console.WriteLine(c.Sound());

            Console.ReadLine();
        }
    }
}
