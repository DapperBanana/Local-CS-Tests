
using OfficeOpenXml;
using System;
using System.IO;

class Program
{
    static void Main()
    {
        FileInfo file = new FileInfo(@"C:\path\to\your\excel-file.xlsx");

        using (ExcelPackage package = new ExcelPackage(file))
        {
            ExcelWorksheet worksheet = package.Workbook.Worksheets[0];
            int rowCount = worksheet.Dimension.Rows;
            int colCount = worksheet.Dimension.Columns;

            double sum = 0;

            for (int row = 2; row <= rowCount; row++)
            {
                sum += Convert.ToDouble(worksheet.Cells[row, 1].Value);
            }

            double average = sum / (rowCount - 1);

            Console.WriteLine($"The average value of the first column in the spreadsheet is: {average}");
        }
    }
}
