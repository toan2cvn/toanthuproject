using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaitapHay
{
    /// <summary>
    /// Insert vao day de co 1 day tang dan
    /// </summary>
    class Baitap6
    {
        public static List<int> InsertAndSort(List<int> list, int number)
        {
            List<int> list1 = list;
            if (list1.Count() == 0)
            {
                list1.Add(number);
                return list1;
            }

            int i = 0;
            foreach (int num in list)
            {
                if (num > number)
                {
                    list1.Insert(i, number);
                    break;
                }
                if (i == list.Count() - 1)
                {
                    list1.Add(number);
                    break;
                }
                i++;
            }

            return list1;
        }

        public static void printList(List<int> list)
        {
            foreach (int num in list)
            {
                Console.Write(string.Format("{0}\t", num));
            }
            Console.WriteLine();
        }
    }
}
