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
    public class CSVWriterTest
    {
        /// <summary>
        /// WriteHeader Test
        /// </summary>
        [Test]
        public void WriteHeaderTest()
        {
            CSVWriter writer = new CSVWriter();
            writer.OpenCsvFile(Directory.GetCurrentDirectory() + "/testOutput.csv");

            writer.WriteHeader();

            writer.CloseCsvFile();
        }

        /// <summary>
        /// WriteResultItem Test
        /// </summary>
        [Test]
        public void WriteResultItemTest()
        {
            ResultItem item = new ResultItem
            {
                No = 1,
                ItemName = "Uriage",
                SheetName = "Sheet1",
                Cell1 = "F14",
                Value1 = "189898989",
                Cell2 = "G34",
                Value2 = "323232323",
                Type = "Type",
                IsDiff = true
            };

            CSVWriter writer = new CSVWriter();
            writer.OpenCsvFile(Directory.GetCurrentDirectory() + "/testOutput.csv");

            writer.WriteResultItem(item);

            writer.CloseCsvFile();
        }
    }
}
