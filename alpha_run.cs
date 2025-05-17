
using System;
using OfficeOpenXml;
using System.IO;

namespace ExcelAnalysis
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\YourUsername\Documents\data.xlsx";

            FileInfo fileInfo = new FileInfo(filePath);

            using (ExcelPackage package = new ExcelPackage(fileInfo))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets[0];

                int rowCount = worksheet.Dimension.Rows;
                int colCount = worksheet.Dimension.Columns;

                for (int row = 1; row <= rowCount; row++)
                {
                    for (int col = 1; col <= colCount; col++)
                    {
                        Console.Write($"{worksheet.Cells[row, col].Value}\t");
                    }
                    Console.WriteLine();
                }

                int totalRows = rowCount - 1; // Excluding header row

                Console.WriteLine($"Total Rows: {totalRows}");
            }
        }
    }
}
