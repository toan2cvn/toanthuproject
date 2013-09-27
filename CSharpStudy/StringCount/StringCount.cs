using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StringCount
{
    class StringCount
    {
        public static int LenB(string str)
        {
            return System.Text.Encoding.GetEncoding("Shift_JIS").GetByteCount(str);
        }
    }
}
