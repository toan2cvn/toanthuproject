using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Microsoft.Office.Interop.Excel;

namespace ExcelCompareTool
{
    public class ExcelReader
    {
        /// <summary>
        /// app
        /// </summary>
        public Application excelApp { get; set;}

        /// <summary>
        /// workbook
        /// </summary>
        public Workbook book { get; set; }

        /// <summary>
        /// Excelを開く
        /// </summary>
        /// <param name="fileName">ファイル名</param>
        /// <returns>結果</returns>
        public bool OpenExcel(string fileName)
        {
            excelApp = new Application();
            excelApp.Visible = false;
            try
            {
                book = excelApp.Workbooks.Open(fileName,
                    Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                    Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// Excelを閉じる
        /// </summary>
        public void CloseExcel()
        {
            book.Close(true, Type.Missing, Type.Missing);
            excelApp.Quit();
        }

        /// <summary>
        /// 配列を読み込み
        /// </summary>
        /// <param name="sheetName">シート名</param>
        /// <param name="range">配列</param>
        /// <param name="type">データタイプ</param>
        /// <returns>値</returns>
        public List<string> ReadCells(string sheetName, string range, string type)
        {
            Worksheet sheet = book.Worksheets[sheetName];
            if (range.Contains(':'))
            {
                string[] rangeArr = range.Split(':');
                return ReadARange(sheet, rangeArr[0], rangeArr[1], type);
            }

            return ReadACell(sheet, range, type);
        }

        /// <summary>
        /// セルを読み込み
        /// </summary>
        /// <param name="sheet">シート</param>
        /// <param name="cellName">セル名</param>
        /// <param name="type">データタイプ</param>
        /// <returns>セル値</returns>
        public List<string> ReadACell(Worksheet sheet, string cellName, string type)
        {
            List<String> rangeList = new List<string>();
            Range range = sheet.get_Range(cellName, Type.Missing);
            string value;
            if (range != null)
            {
                if (type == Properties.Resources.TYPE_FORMULA)
                {
                    value = Convert.ToString(range.Formula);
                }
                else
                {
                    value = Convert.ToString(range.Value2);
                }

                rangeList.Add(value);
            }

            return rangeList;
        }

        /// <summary>
        /// 長方形を読み込み
        /// </summary>
        /// <param name="sheet">シート</param>
        /// <param name="cellNameFrom">セル名から</param>
        /// <param name="cellNameTo">セル名まで</param>
        /// <param name="type">データタイプ</param>
        /// <returns>値</returns>
        public List<string> ReadARange(Worksheet sheet, string cellNameFrom, string cellNameTo, string type)
        {
            List<String> rangeList = new List<string>();
            Range range = sheet.get_Range(cellNameFrom, cellNameTo);
            if (range != null)
            {
                Array values;
                if (type == Properties.Resources.TYPE_FORMULA)
                {
                    values = range.Cells.Formula;
                }
                else
                {
                    values = range.Cells.Value;
                }

                rangeList = ConvertToStringArray(values);
            }

            return rangeList;
        }

        /// <summary>
        /// 配列交換
        /// </summary>
        /// <param name="values">システム配列</param>
        /// <returns>文字列リスト</returns>
        private List<string> ConvertToStringArray(Array values)
        {
            object[] valueArr = values.OfType<object>().Select(o => o.ToString()).ToArray();
            List<object> objList = new List<object>(valueArr);
            IEnumerable<string> strList = objList.OfType<string>();
            return new List<string>(strList);
        }
    }
}
