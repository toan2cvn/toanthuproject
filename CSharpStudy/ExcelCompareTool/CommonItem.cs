using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExcelCompareTool
{
    public class CommonItem
    {
        /// <summary>
        /// 項目番号
        /// </summary>
        public int No { get; set; }

        /// <summary>
        /// 項目名
        /// </summary>
        public string ItemName { get; set; }

        /// <summary>
        /// シート名
        /// </summary>
        public string SheetName { get; set; }

        /// <summary>
        /// 比較タイプ
        /// </summary>
        public string Type { get; set; }
    }
}
