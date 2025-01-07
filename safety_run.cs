
using System;
using OfficeOpenXml;

namespace ExcelReader
{
    class Program
    {
        static void Main(string[] args)
        {
            // Load the Excel file
            var fileInfo = new System.IO.FileInfo("data.xlsx");
            using (var package = new ExcelPackage(fileInfo))
            {
                // Get the first worksheet
                var worksheet = package.Workbook.Worksheets[0];
                
                // Iterate through the rows and columns
                for (int row = worksheet.Dimension.Start.Row; row <= worksheet.Dimension.End.Row; row++)
                {
                    for (int col = worksheet.Dimension.Start.Column; col <= worksheet.Dimension.End.Column; col++)
                    {
                        var cellValue = worksheet.Cells[row, col].Value;
                        Console.WriteLine($"Cell ({row}, {col}): {cellValue}");
                    }
                }
                
                // Get the sum of values in a specific column
                int columnToSum = 2;
                double sum = 0;
                for (int row = worksheet.Dimension.Start.Row + 1; row <= worksheet.Dimension.End.Row; row++)
                {
                    var cellValue = worksheet.Cells[row, columnToSum].Value;
                    sum += Convert.ToDouble(cellValue);
                }
                Console.WriteLine($"Sum of column {columnToSum}: {sum}");
            }
        }
    }
}
