
using OfficeOpenXml;
using System;
using System.IO;

class Program
{
    static void Main()
    {
        // Load the Excel file
        FileInfo file = new FileInfo("data.xlsx");
        using ExcelPackage package = new ExcelPackage(file);

        // Get the first worksheet in the Excel file
        ExcelWorksheet worksheet = package.Workbook.Worksheets[0];

        // Get the number of rows and columns in the worksheet
        int rowCount = worksheet.Dimension.Rows;
        int columnCount = worksheet.Dimension.Columns;

        // Analyze the data in the worksheet
        double total = 0;
        int count = 0;

        for (int row = 2; row <= rowCount; row++)
        {
            double value = Convert.ToDouble(worksheet.Cells[row, 1].Value);
            total += value;
            count++;
        }

        double average = total / count;

        Console.WriteLine($"Total: {total}");
        Console.WriteLine($"Average: {average}");

        Console.ReadLine();
    }
}
