using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class CsvDataAnalyzer
{
    static void Main(string[] args)
    {
        string filePath = "data.csv"; // Path to your CSV file
        
        // Read all lines from the CSV file
        var lines = File.ReadAllLines(filePath);
        if (lines.Length == 0)
        {
            Console.WriteLine("CSV file is empty or not found.");
            return;
        }

        // Parse header
        var headers = lines[0].Split(',');

        // Parse data rows
        var dataRows = lines.Skip(1).Select(line => line.Split(',')).ToList();

        // Example analysis: Count number of rows
        Console.WriteLine($"Total Rows: {dataRows.Count}");

        // Example analysis: Find columns with numeric data
        for (int col = 0; col < headers.Length; col++)
        {
            bool isNumericColumn = true;
            foreach (var row in dataRows)
            {
                if (!double.TryParse(row[col], out _))
                {
                    isNumericColumn = false;
                    break;
                }
            }

            if (isNumericColumn)
            {
                var columnData = dataRows.Select(row => double.Parse(row[col]));
                Console.WriteLine($"Column '{headers[col]}' is numeric. Stats:");
                Console.WriteLine($"  Min: {columnData.Min()}");
                Console.WriteLine($"  Max: {columnData.Max()}");
                Console.WriteLine($"  Average: {columnData.Average()}");
            }
        }
    }
}