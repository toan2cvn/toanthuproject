using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaitapHay
{
    /// <summary>
    /// Tron 2 so cho truoc de tim so nho nhat va giu nguyen thu tu
    /// </summary>
    class Baitap1
    {
        public static void GhepSo(int num1, int num2)
        {
            char[] strNum1 = num1.ToString().ToCharArray();
            char[] strNum2 = num2.ToString().ToCharArray();
            char[] strMin = new char[strNum1.Length + strNum2.Length];
            char[] strMax = new char[strNum1.Length + strNum2.Length];
            int iMin = 0;
            //int iMax = 0;
            int i = 0, j = 0;

            while (iMin < strNum1.Length + strNum2.Length)
            {
                if (j == strNum2.Length)
                {
                    strMin[iMin] = strNum1[i];
                    //strMax[iMax] = strNum2[j];
                    i++;
                    iMin++;
                    continue;
                }
                if (i == strNum1.Length)
                {
                    strMin[iMin] = strNum2[j];
                    j++;
                    iMin++;
                    continue;
                }
                if (strNum1[i] > strNum2[j])
                {
                    //strMax[iMax] = strNum1[i];
                    strMin[iMin] = strNum2[j];
                    j++;
                }
                else
                {
                    strMin[iMin] = strNum1[i];
                    //strMax[iMax] = strNum2[j];
                    i++;
                }
                //iMax++;
                iMin++;
            }
            int min = int.Parse(new string(strMin));
            //int max = int.Parse(strMax.ToString());

            Console.WriteLine(min);
        }
    }
}
