using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SubString
{
    class SubString
    {
        public static int SearchSubString(string str, string sub)
        {
            int count = 0;
            char[] strArr = str.ToCharArray();
            char[] subArr = sub.ToCharArray();
            int index = 0;
            int j = 0;
            bool check = true;
            foreach (char c in strArr)
            {
                if (c == subArr[0])
                {
                    j = index;
                    check = true;
                    for (int i = 0; i < subArr.Length; i++)
                    {
                        if (j == strArr.Length || strArr[j] != subArr[i])
                        {
                            check = false;
                            break;
                        }
                        j++;
                    }
                    if (check)
                    {
                        count++;
                    }
                }
                index++;
            }
            return count;
        }
    }
}
