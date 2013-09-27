using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace BaitapHay
{
    class Program
    {
        static void Main(string[] args)
        {
            // CommonSubString
            string str1 = @"<a href=popup.co.jp>popup
";
            string str2 = "popup.co.jp";
            Console.WriteLine(CommonSubString.CheckCommonSub(str1, str2));

            /*
            // Bai tap 1
            int num1 = 25;
            int num2 = 4131;
            Baitap1.GhepSo(num1, num2);

            // Bai tap 2
            int[][] matrix = new int[3][] { new int[] { 3, 1, 2 }, new int[] { 5, 3, 6 }, new int[] { 8, 2, 1 } };
            ArrayList list = Baitap2.YenNgua(matrix);
            foreach (int elem in list)
            {
                Console.Write(elem + "\t");
            }
            Console.WriteLine();
            Console.WriteLine("Ket thuc 2");

            // Bai tap 3
            int n = 31, m = 41;
            List<int> list3 = Baitap3.PrimeNumbers(n, m);
            foreach (int elem in list3)
            {
                Console.Write(elem + "\t");
            }
            Console.WriteLine();
            Console.WriteLine("Ket thuc 3");

            // Bai tap 4
            int[] arrNum = new int[] { 3,1, 8, 5, 6, 4, 7};
            Console.WriteLine(Baitap4.TheSecondSmallNumber(arrNum));

            // Bai tap 5
            n = 300567200;
            Dictionary<int, int> dic = Baitap5.Primes(n);
            string out5 = string.Format("{0} = ", n);
            foreach (int key in dic.Keys)
            {
                out5 += string.Format("{0}^{1} x ", key, dic[key]);
            }
            Console.WriteLine(out5);
            Console.WriteLine("Ket thuc 5");

            // Bai tap 6
            string input = "";
            List<int> list6 = new List<int>();
            while (true)
            {
                input = Console.ReadLine();
                if (input.Trim() == "")
                    break;
                list6 = Baitap6.InsertAndSort(list6, Convert.ToInt32(input));
                Baitap6.printList(list6);
            }
            Console.WriteLine("Ket thuc 6");

            // Bai tap 7
            List<int> list7 = new List<int>();
            while (true)
            {
                Console.Write("Nhap so: ");
                input = Console.ReadLine();
                if (input.Trim() == "")
                    break;
                list7.Add(Convert.ToInt32(input));
                Baitap6.printList(list7);
            }
            Console.WriteLine("Ket qua: ");
            Baitap6.printList(Baitap7.MoveListElem(list7));
            Console.WriteLine("Ket thuc 7");

            // Bai tap ChangeBase
            Console.Write("Nhap so: ");
            input = Console.ReadLine();
            Console.Write("Nhap base: ");
            string input2 = Console.ReadLine();
            int num = Convert.ToInt32(input);
            int bases = Convert.ToInt32(input2);
            Console.WriteLine(string.Format("Ket qua co so {0}: {1}",bases,ChangeBase.ChangBaseLess16(num,bases)));
            Console.WriteLine("Ket thuc ChangeBase");
            */
            // Ket thuc
            Console.ReadLine();
        }
    }
}
