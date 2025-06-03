
using OfficeOpenXml;
using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        var filePath = "your_file_path_here.xlsx";

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
                    Console.Write(worksheet.Cells[row, col].Value + "\t");
                }
                Console.WriteLine();
            }

            // Example analysis: sum of all values in a specific column
            int sum = 0;
            int colToSum = 2;  // Change this to specify the column to sum
            for (int row = 1; row <= rowCount; row++)
            {
                int cellValue;
                if (int.TryParse(worksheet.Cells[row, colToSum].Value.ToString(), out cellValue))
                {
                    sum += cellValue;
                }
            }

            Console.WriteLine("Sum of column " + colToSum + ": " + sum);
        }
    }
}
