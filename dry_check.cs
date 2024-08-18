
using OfficeOpenXml;
using System;
using System.IO;

class Program
{
    static void Main()
    {
        FileInfo fileInfo = new FileInfo("sample.xlsx");

        using (ExcelPackage package = new ExcelPackage(fileInfo))
        {
            ExcelWorksheet worksheet = package.Workbook.Worksheets[0];
            int rowCount = worksheet.Dimension.Rows;
            int colCount = worksheet.Dimension.Columns;

            Console.WriteLine($"Number of rows: {rowCount}");
            Console.WriteLine($"Number of columns: {colCount}");

            for (int row = 1; row <= rowCount; row++)
            {
                for (int col = 1; col <= colCount; col++)
                {
                    Console.Write($"{worksheet.Cells[row, col].Value}\t");
                }
                Console.WriteLine();
            }
        }
    }
}
