using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExcelCompareTool
{
    public class ResultItem : CommonItem
    {
        /// <summary>
        /// 比較元のセル
        /// </summary>
        public string Cell1 { get; set; }

        /// <summary>
        /// 比較元の値
        /// </summary>
        public string Value1 { get; set; }

        /// <summary>
        /// 比較先のセル
        /// </summary>
        public string Cell2 { get; set; }

        /// <summary>
        /// 比較先の値
        /// </summary>
        public string Value2 { get; set; }

        /// <summary>
        /// 差異あるかないか
        /// </summary>
        public bool IsDiff { get; set; }
    }
}
