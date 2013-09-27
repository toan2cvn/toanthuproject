using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaitapHay
{
    public class CommonSubString
    {
        public static bool CheckCommonSub(string str1, string str2)
        {
            char c = ' ';
            int occ = -1;
            for (int i = str1.Length - 2; i >= 0; i--)
            {
                if (str1[i] != '\t' && str1[i] != '\r')
                {
                    c = str1[i];
                    occ = i;
                    break;
                }
            }

            if (c == ' ' || c == '>')
            {
                return false;
            }

            string temp = string.Copy(str2);
            int pos = -1;
            do
            {
                pos = temp.LastIndexOf(c.ToString(), StringComparison.OrdinalIgnoreCase);
                if (pos >= 0)
                {
                    int j = pos;
                    int k = occ;
                    for (j = pos; j >= 0; j--)
                    {
                        char c1 = str1[k];
                        char c2 = temp[j];
                        if (c1 != c2 && Math.Abs(c1 - c2) != 32)
                        {
                            break;
                        }

                        k--;
                    }

                    if (j < 0)
                    {
                        return true;
                    }

                    temp = temp.Substring(0, pos);
                }
            }while (pos != -1);

            return false;
        }
    }
}
