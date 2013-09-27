using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaitapHay
{
    /// <summary>
    /// Nhap day cac so nguyen duong, chuyen cac so chia het cho 2 ve dau day,
    /// cac so ko chia het cho 3 ve cuoi day, va cac so chia het cho ca 2, 3 
    /// hoac ko chia het cho ca 2, 3 ve giua day
    /// </summary>
    class Baitap7
    {
        public static List<int> MoveListElem(List<int> list)
        {
            int len = list.Count();
            int i = 0;
            int j = len-1;

            List<int> list1 = new List<int>(list);
            List<int> list2 = new List<int>();
            //int len1 = list1.Count();

            foreach (int num in list)
            {
                if (num % 2 == 0 && num % 3 != 0)
                {
                    list1[i++] = num;
                }
                else if (num % 3 == 0 && num % 2 != 0)
                {
                    list1[j--] = num;
                }
                else
                {
                    list2.Add(num);
                }
            }
            foreach (int num in list2)
            {
                list1[i++] = num;
            }
            return list1;
        }
    }
}
