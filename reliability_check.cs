
using System;
using OfficeOpenXml;
using System.IO;

namespace ExcelDataReader
{
    class Program
    {
        static void Main(string[] args)
        {
            FileInfo file = new FileInfo("SampleData.xlsx");
            using (ExcelPackage package = new ExcelPackage(file))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets[0];
                int rowCount = worksheet.Dimension.Rows;
                int colCount = worksheet.Dimension.Columns;

                Console.WriteLine("Reading data from Excel spreadsheet:");

                for (int row = 1; row <= rowCount; row++)
                {
                    for (int col = 1; col <= colCount; col++)
                    {
                        var cellValue = worksheet.Cells[row, col].Value;
                        Console.Write(cellValue + "\t");
                    }
                    Console.WriteLine();
                }

                // Analyze data
                double total = 0;
                for (int row = 2; row <= rowCount; row++) // skipping header row
                {
                    double value;
                    if (double.TryParse(worksheet.Cells[row, 2].Value.ToString(), out value))
                    {
                        total += value;
                    }
                }

                Console.WriteLine("Total value in column 2: " + total);
            }
        }
    }
}
