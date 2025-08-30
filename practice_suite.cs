
using System;
using Microsoft.Office.Interop.Excel;

namespace ExcelReader
{
    class Program
    {
        static void Main(string[] args)
        {
            Application excelApp = new Application();
            Workbook workbook = excelApp.Workbooks.Open("example.xlsx");
            Worksheet worksheet = workbook.Sheets[1];
            Range range = worksheet.UsedRange;

            // Loop through each row in the spreadsheet
            for (int row = 1; row <= range.Rows.Count; row++)
            {
                // Read data from the cells in the row
                string cell1 = range.Cells[row, 1].Value2.ToString();
                string cell2 = range.Cells[row, 2].Value2.ToString();

                // Analyze the data
                Console.WriteLine($"Data in Row {row}: {cell1}, {cell2}");
            }

            // Close the workbook and Excel application
            workbook.Close();
            excelApp.Quit();
        }
    }
}
