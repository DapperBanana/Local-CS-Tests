
using OfficeOpenXml;
using System;
using System.IO;

class Program
{
    static void Main()
    {
        FileInfo fileInfo = new FileInfo("data.xlsx");

        using (ExcelPackage package = new ExcelPackage(fileInfo))
        {
            ExcelWorksheet worksheet = package.Workbook.Worksheets[0];

            int rowCount = worksheet.Dimension.Rows;
            int colCount = worksheet.Dimension.Columns;

            int columnToAnalyze = 2; // Column B

            double total = 0;
            int count = 0;

            for (int row = 2; row <= rowCount; row++) // Start at row 2 to skip header
            {
                double cellValue = Convert.ToDouble(worksheet.Cells[row, columnToAnalyze].Value);

                total += cellValue;
                count++;
            }

            double average = total / count;

            Console.WriteLine($"Average value in column {columnToAnalyze}: {average}");
        }
    }
}
