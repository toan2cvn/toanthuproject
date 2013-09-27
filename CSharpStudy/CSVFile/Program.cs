using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace CSVFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\test.csv";
            StringBuilder sb = new StringBuilder();
            string lineData = "";
            long init = 1037242281;
            for (long index = init; index < init + 112000; index++)
            {
                lineData = string.Format("'{0}'", index);
                sb.AppendLine(lineData);
            }
           File.WriteAllText(filePath, sb.ToString()); 
        }
    }
}