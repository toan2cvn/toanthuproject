using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExcelCompareTool
{
    public class ExcelComparer
    {
        /// <summary>
        /// 比較元リーダー
        /// </summary>
        private ExcelReader exelReader1 { get; set; }

        /// <summary>
        /// 比較先リーダー
        /// </summary>
        private ExcelReader exelReader2 { get; set; }

        /// <summary>
        /// エラー書き込むためのライタ
        /// </summary>
        private CSVWriter csvWriter { get; set; }

        /// <summary>
        /// Excel比較
        /// </summary>
        /// <param name="fileName1">比較元ファイル名</param>
        /// <param name="fileName2">比較先ファイル名</param>
        /// <param name="gridData">対象列データ</param>
        /// <returns></returns>
        public bool CompareExcel(string fileName1, string fileName2, List<List<string>> gridData)
        {
            return false;
        }
    }
}
