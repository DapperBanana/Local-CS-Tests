
using ExcelDataReader;
using System;
using System.Data;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        // Load the Excel file into a stream
        FileStream stream = File.Open("data.xlsx", FileMode.Open, FileAccess.Read);

        // Create a reader for the Excel file
        IExcelDataReader reader = ExcelReaderFactory.CreateOpenXmlReader(stream);

        // Read the data from the Excel file into a DataSet
        DataSet result = reader.AsDataSet();

        // Close the reader and stream
        reader.Close();
        stream.Close();

        // Get the first table from the DataSet
        DataTable table = result.Tables[0];

        // Perform analysis on the data
        int rowCount = table.Rows.Count;
        int columnCount = table.Columns.Count;

        Console.WriteLine("Number of rows: " + rowCount);
        Console.WriteLine("Number of columns: " + columnCount);

        // Iterate through the rows and columns to analyze the data
        for (int i = 0; i < rowCount; i++)
        {
            for (int j = 0; j < columnCount; j++)
            {
                Console.Write(table.Rows[i][j] + "\t");
            }
            Console.WriteLine();
        }
    }
}
