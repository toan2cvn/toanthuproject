using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SubString
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "8ahelloebchellood";
            string sub = "hello";
            str = "110010011001001";
            sub = "1001";
            str = "010101010100";
            sub = "01010";
            int count = SubString.SearchSubString(str, sub);
            Console.WriteLine(string.Format("So lan gap: {0}",count));
            Console.ReadLine();
        }
    }
}
