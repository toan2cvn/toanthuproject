using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using ExcelCompareTool;
using System.IO;

namespace ExcelCompareToolTest
{
    [TestFixture]
    public class ExcelReaderTest
    {
        /// <summary>
        /// OpenExcel Test
        /// </summary>
        [Test]
        public void OpenExcelTest()
        {
            ExcelReader excelRW = new ExcelReader();
            bool actual = excelRW.OpenExcel(Directory.GetCurrentDirectory() + "/testBook.xlsx");
            excelRW.CloseExcel();
            Assert.IsTrue(actual);
        }

        /// <summary>
        /// ReadCells Test Case A Cell
        /// </summary>
        [Test]
        public void ReadCellsTest_CaseACell()
        {
            ExcelReader excelRW = new ExcelReader();
            excelRW.OpenExcel(Directory.GetCurrentDirectory() + "/testBook.xlsx");
            try
            {
                List<string> actual = excelRW.ReadCells("計画", "C3", "値");
                Assert.AreEqual(actual[0], "要件定義書作成");
            }
            finally
            {
                excelRW.CloseExcel();
            }
        }

        /// <summary>
        /// ReadCells Test Case A Cell
        /// </summary>
        [Test]
        public void ReadCellsTest_CaseManyCell()
        {
            ExcelReader excelRW = new ExcelReader();
            excelRW.OpenExcel(Directory.GetCurrentDirectory() + "/testBook.xlsx");
            try
            {
                List<string> actual = excelRW.ReadCells("計画", "E3:G8", "式");
                //Assert.AreEqual(actual[0], "要件定義書作成");
                Assert.AreEqual(18, actual.Count);
            }
            finally
            {
                excelRW.CloseExcel();
            }
        }
    }
}
