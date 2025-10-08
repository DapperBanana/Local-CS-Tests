
using System;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        string filePath = @"data.csv";
        string[] lines = File.ReadAllLines(filePath);

        // Get headers
        string[] headers = lines[0].Split(',');

        // Display headers
        Console.WriteLine("Headers:");
        foreach (string header in headers)
        {
            Console.WriteLine(header);
        }

        // Get data rows
        var dataRows = lines.Skip(1);

        // Analyze data
        int totalRows = dataRows.Count();
        int totalColumns = headers.Length;

        Console.WriteLine($"Total rows: {totalRows}");
        Console.WriteLine($"Total columns: {totalColumns}");

        // Calculate average values
        double[] averages = new double[totalColumns];
        for(int i = 0; i < totalColumns; i++)
        {
            double sum = 0;
            foreach (var row in dataRows)
            {
                string[] values = row.Split(',');
                sum += double.Parse(values[i]);
            }
            averages[i] = sum / totalRows;
            Console.WriteLine($"Average value for {headers[i]}: {averages[i]}");
        }
    }
}
