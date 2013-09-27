using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaitapHay
{
    /// <summary>
    /// Tim cac so nguyen to trong khoang tu n den m
    /// </summary>
    class Baitap3
    {
        public static List<int> PrimeNumbers(int n, int m)
        {
            List<int> list = new List<int>();
            int k = n;
            while (k <= m)
            {
                if (CheckPrime(k))
                {
                    list.Add(k);
                }
                k++;
            }
            return list;
        }

        public static bool CheckPrime(int k)
        {
            for (int i = 2; i <= k / 2; i++)
            {
                if (k % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    } 
}
