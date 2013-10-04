using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ExcelCompareTool
{
    public class CSVWriter
    {
        /// <summary>
        /// ライター
        /// </summary>
        private StreamWriter writer;

        /// <summary>
        /// ファイル開く
        /// </summary>
        /// <param name="fileName">ファイル名</param>
        /// <returns>結果</returns>
        public bool OpenCsvFile(string fileName)
        {
            try
            {
                writer = new StreamWriter(fileName, false, Encoding.GetEncoding("shift-jis"));
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// ファイル閉じる
        /// </summary>
        public void CloseCsvFile()
        {
            writer.Close();
            writer.Dispose();
        }

        /// <summary>
        /// 差異がある結果をcsvファイルに書く
        /// </summary>
        /// <param name="resultList">ResultItemList</param>
        public void WriteCompareResult(List<ResultItem> resultList)
        {
            foreach(ResultItem result in resultList)
            {
                WriteResultItem(result);
            }
        }

        /// <summary>
        /// 差異がある結果をcsvファイルに書く
        /// </summary>
        /// <param name="result">ResultItem</param>
        public void WriteResultItem(ResultItem result)
        {
            StringBuilder sb = new StringBuilder();
            if (result.No != -1)
            {
                sb.Append(result.No).Append(',');
            }
            else
            {
                sb.Append("No").Append(',');
            }
            sb.Append(result.ItemName).Append(',');
            sb.Append(result.SheetName).Append(',');
            sb.Append(result.Cell1).Append(',');
            sb.Append(result.Value1).Append(',');
            sb.Append(result.Cell2).Append(',');
            sb.Append(result.Value2).Append(',');
            sb.Append(result.Type).Append(',');
            if (result.IsDiff)
            {
                sb.Append("○");
            }
            else
            {
                sb.Append("差異").Append(',');
            }

            writer.WriteLine(sb.ToString());
        }

        /// <summary>
        /// ヘッダー書く
        /// </summary>
        public void WriteHeader()
        {
            ResultItem header = new ResultItem
            {
                No = -1,
                ItemName = "項目名",
                SheetName = "シート名",
                Cell1 = "セル元",
                Value1 = "値",
                Cell2 = "セル先",
                Value2 = "値",
                Type = "Type",
                IsDiff = false
            };

            WriteResultItem(header);
        }
    }
}
