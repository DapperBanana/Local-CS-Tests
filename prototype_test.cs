
using System;
using OfficeOpenXml;

namespace ExcelDataAnalysis
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = "data.xlsx";

            using (var package = new ExcelPackage(new System.IO.FileInfo(filePath)))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets[0];
                int rowCount = worksheet.Dimension.Rows;
                int colCount = worksheet.Dimension.Columns;

                // Display the data from the Excel spreadsheet
                for (int row = 1; row <= rowCount; row++)
                {
                    for (int col = 1; col <= colCount; col++)
                    {
                        Console.Write($"{worksheet.Cells[row, col].Value}\t");
                    }
                    Console.WriteLine();
                }

                // Perform some analysis on the data
                double sum = 0;
                int count = 0;
                for (int row = 2; row <= rowCount; row++) // Assuming the first row contains headers
                {
                    double value;
                    if (double.TryParse(worksheet.Cells[row, 2].Value.ToString(), out value))
                    {
                        sum += value;
                        count++;
                    }
                }
                double average = sum / count;

                Console.WriteLine($"The average value in column B is: {average}");
            }
        }
    }
}
