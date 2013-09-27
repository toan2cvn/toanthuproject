using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace BaitapHay
{
    /// <summary>
    /// Tim diem Yen Ngua, là điểm có giá trị nhỏ nhất theo hàng và lớn nhất theo cột
    /// </summary>
    class Baitap2
    {
        public static ArrayList YenNgua(int[][] matrix)
        {
            ArrayList list = new ArrayList();
            for (int i = 0; i < matrix.Length; i++)
            {
                int max = matrix[i].Max();
                int maxIn = matrix[i].ToList().IndexOf(matrix[i].Max());
                int min = max;
                for (int j = 0; j < matrix.Length; j++)
                {
                    if (matrix[j][maxIn] < min)
                    {
                        min = matrix[j][maxIn];
                        break;
                    }
                }
                if (min == max)
                {
                    list.Add(min);
                }
            }
            return list;
        }
    }
}
