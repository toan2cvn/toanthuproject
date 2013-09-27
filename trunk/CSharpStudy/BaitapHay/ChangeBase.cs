using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaitapHay
{
    /// <summary>
    /// CHuyen doi sang co so nhap tu ban phim
    /// </summary>
    class ChangeBase
    {
        public static string ChangBaseLess16(int num, int bases)
        {
            int num1 = num;
            StringBuilder str = new StringBuilder();
            int bases1;
            while (true)
            {
                bases1 = num1 % bases;
                num1 = num1 / bases;
                if (bases1 >= 10)
                {
                    str.Insert(0, BaseValue.ConvertNumber(bases1));
                }
                else
                {
                    str.Insert(0, string.Format("{0}",bases1));
                }
                if (num1 == 0)
                {
                    break;
                }
            }
            return str.ToString();
        }
        class BaseValue
        {
            public static char ConvertNumber(int num)
            {
                int num10 = 10;
                char cha10 = 'A';
                int cha = cha10 + (num - num10);
                return Convert.ToChar(cha);
            }
        }
    }
}
