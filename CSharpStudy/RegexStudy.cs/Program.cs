using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace RegexStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            string email = "1212-dsd@ddd.2co";
            Console.WriteLine(Ext_IsValidEmailAddress(email));
            Console.ReadLine();
        }
        public static bool Ext_IsValidEmailAddress(string s)
        {
            Regex regex = new Regex(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$");
            return regex.IsMatch(s);
        }
    }
}
