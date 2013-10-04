using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExcelCompareTool
{
    public class InputItem : CommonItem
    {
        /// <summary>
        /// 比較元Range
        /// </summary>
        public string Range1 { get; set; }

        /// <summary>
        /// 比較先Range
        /// </summary>
        public string Range2 { get; set; }

        public InputItem(List<string> rowData)
        {
            this.No = int.Parse(rowData[0]);
            this.ItemName = rowData[1];
            this.SheetName = rowData[2];
            this.Range1 = rowData[3];
            this.Range2 = rowData[4];
            this.Type = rowData[5];
        }
    }
}
