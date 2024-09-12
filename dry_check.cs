
using System;
using OfficeOpenXml;
using System.IO;

class Program
{
    static void Main()
    {
        FileInfo file = new FileInfo(@"example.xlsx");

        using (ExcelPackage package = new ExcelPackage(file))
        {
            ExcelWorksheet worksheet = package.Workbook.Worksheets[0];
            int rowCount = worksheet.Dimension.Rows;
            int colCount = worksheet.Dimension.Columns;

            // Print out the data in the Excel spreadsheet
            for (int row = 1; row <= rowCount; row++)
            {
                for (int col = 1; col <= colCount; col++)
                {
                    Console.Write(worksheet.Cells[row, col].Value.ToString() + "\t");
                }
                Console.WriteLine();
            }

            // Perform some analysis on the data
            double sum = 0;
            for (int row = 2; row <= rowCount; row++) // skipping the header row
            {
                sum += double.Parse(worksheet.Cells[row, 2].Value.ToString());
            }

            double average = sum / (rowCount - 1);

            Console.WriteLine("Sum of column 2: " + sum);
            Console.WriteLine("Average of column 2: " + average);
        }
    }
}
