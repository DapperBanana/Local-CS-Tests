
using System;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        // Read the data from the CSV file
        string[] lines = File.ReadAllLines("data.csv");

        // Initialize variables for analysis
        int totalRows = lines.Length;
        int totalColumns = lines[0].Split(',').Length;
        int[] columnTotals = new int[totalColumns];

        // Perform analysis
        foreach (string line in lines)
        {
            string[] values = line.Split(',');

            for (int i = 0; i < totalColumns; i++)
            {
                columnTotals[i] += int.Parse(values[i]);
            }
        }

        // Display analysis results
        Console.WriteLine($"Total rows: {totalRows}");
        Console.WriteLine($"Total columns: {totalColumns}");

        for (int i = 0; i < totalColumns; i++)
        {
            Console.WriteLine($"Total for column {i + 1}: {columnTotals[i]}");
        }

        // Calculate average for each column
        double[] columnAverages = columnTotals.Select(x => (double)x / totalRows).ToArray();

        for (int i = 0; i < totalColumns; i++)
        {
            Console.WriteLine($"Average for column {i + 1}: {columnAverages[i]:N2}");
        }
    }
}
