
using OfficeOpenXml;
using System;
using System.IO;

class Program
{
    static void Main()
    {
        FileInfo fileInfo = new FileInfo(@"C:\path\to\your\excel\file.xlsx");

        using (ExcelPackage package = new ExcelPackage(fileInfo))
        {
            ExcelWorksheet worksheet = package.Workbook.Worksheets[0]; // Assuming the data is in the first worksheet

            int rowCount = worksheet.Dimension.Rows;
            int columnToAnalyze = 1; // Change this to the index of the column you want to analyze

            double sum = 0;

            for (int row = 2; row <= rowCount; row++) // Assuming the first row contains headers
            {
                double cellValue = worksheet.Cells[row, columnToAnalyze].GetValue<double>();
                sum += cellValue;
            }

            double average = sum / (rowCount - 1); // Subtract 1 to exclude the header row

            Console.WriteLine($"Average value of column {columnToAnalyze}: {average}");
        }
    }
}
