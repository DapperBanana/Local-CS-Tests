
using OfficeOpenXml;
using System;
using System.IO;
using System.Linq;

namespace ExcelAnalyzer
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = "example.xlsx";

            FileInfo fileInfo = new FileInfo(filePath);

            using (ExcelPackage package = new ExcelPackage(fileInfo))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets.FirstOrDefault();

                if (worksheet != null)
                {
                    // Get the number of rows and columns in the worksheet
                    int rows = worksheet.Dimension.Rows;
                    int columns = worksheet.Dimension.Columns;

                    Console.WriteLine("Rows: " + rows);
                    Console.WriteLine("Columns: " + columns);

                    // Analyze the data
                    double sum = 0;
                    int count = 0;

                    for (int row = 2; row <= rows; row++) // Assuming the first row contains headers
                    {
                        double value;
                        
                        if (Double.TryParse(worksheet.Cells[row, 1].Value.ToString(), out value))
                        {
                            sum += value;
                            count++;
                        }
                    }

                    double average = sum / count;

                    Console.WriteLine("Sum of values in column 1: " + sum);
                    Console.WriteLine("Average of values in column 1: " + average);
                }
            }
        }
    }
}
