
using OfficeOpenXml;
using System;
using System.IO;

class Program
{
    static void Main()
    {
        FileInfo file = new FileInfo("Sample.xlsx");

        using (ExcelPackage package = new ExcelPackage(file))
        {
            ExcelWorksheet worksheet = package.Workbook.Worksheets[0];

            int rowCount = worksheet.Dimension.Rows;
            int colCount = worksheet.Dimension.Columns;

            double sum = 0;
            int count = 0;

            for (int row = 2; row <= rowCount; row++) // Start from row 2, assuming row 1 is headers
            {
                double value;
                if (Double.TryParse(worksheet.Cells[row, 1].Value.ToString(), out value))
                {
                    sum += value;
                    count++;
                }
            }

            double average = sum / count;

            Console.WriteLine($"Total count: {count}");
            Console.WriteLine($"Total sum: {sum}");
            Console.WriteLine($"Average value: {average}");
        }
    }
}
