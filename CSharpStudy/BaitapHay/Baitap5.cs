using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaitapHay
{
    /// <summary>
    /// Phan tích thanh so nguyen to
    /// </summary>
    class Baitap5
    {
        public static Dictionary<int, int> Primes(int n)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();
            //List<int> listPrimes = Baitap3.PrimeNumbers(2, n / 2);
            //if (Baitap3.CheckPrime(n))
            //    listPrimes.Add(n);
            int i = 2;
            int mu = 0;
            int m = n;
            do
            {
                if (Baitap3.CheckPrime(n))
                {
                    dic[n] = 1;
                    break;
                }
                if (Baitap3.CheckPrime(i) && n % i == 0)
                {
                    n = n / i;
                    mu++;
                    dic[i] = mu;
                }
                else
                {
                    mu = 0;
                    i++;
                }
                if (n == 1)
                    break;
            }while (i <= m / 2);
            return dic;
        }
    }
}
