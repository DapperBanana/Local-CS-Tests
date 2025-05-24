
using System;
using OfficeOpenXml;
using System.IO;

namespace ExcelAnalyzer
{
    class Program
    {
        static void Main(string[] args)
        {
            FileInfo file = new FileInfo("data.xlsx");
            
            using (ExcelPackage package = new ExcelPackage(file))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets[0];
                
                int rowCount = worksheet.Dimension.Rows;
                int colCount = worksheet.Dimension.Columns;
                
                for (int row = 1; row <= rowCount; row++)
                {
                    for (int col = 1; col <= colCount; col++)
                    {
                        Console.WriteLine("Cell Value at row {0} and column {1}: {2}", row, col, worksheet.Cells[row, col].Value);
                    }
                }
            }
        }
    }
}
