
using OfficeOpenXml;
using System;
using System.IO;

namespace ExcelDataReader
{
    class Program
    {
        static void Main(string[] args)
        {
            FileInfo file = new FileInfo(@"C:\path\to\your\excel\spreadsheet.xlsx");

            using (ExcelPackage package = new ExcelPackage(file))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets[0];

                int rows = worksheet.Dimension.Rows;
                int columns = worksheet.Dimension.Columns;

                for (int row = 1; row <= rows; row++)
                {
                    for (int col = 1; col <= columns; col++)
                    {
                        Console.Write($"{worksheet.Cells[row, col].Value}\t");
                    }
                    Console.WriteLine();
                }

                // Analyze data here
            }
        }
    }
}
