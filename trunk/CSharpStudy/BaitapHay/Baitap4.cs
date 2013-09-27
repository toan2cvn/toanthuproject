using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaitapHay
{
    /// <summary>
    /// Tim so be thu 2 trong 1 day so
    /// </summary>
    class Baitap4
    {
        public static int TheSecondSmallNumber(int[] arrNum)
        {
            int min = arrNum.Min();
            int min2 = min;
            foreach (int num in arrNum)
            {
                if (min2 != num && min2 == min)
                {
                    min2 = num;
                }
                else if (min2 > num && num != min)
                {
                    min2 = num;
                }
            }
            return min2;
        }
    }
}
