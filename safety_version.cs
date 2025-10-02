
using System;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        string csvFile = "data.csv";

        // Read all lines from the CSV file
        string[] lines = File.ReadAllLines(csvFile);

        // Analyze the data
        int totalRows = lines.Length;
        int totalColumns = lines[0].Split(',').Length;

        Console.WriteLine($"Total rows: {totalRows}");
        Console.WriteLine($"Total columns: {totalColumns}");

        // Calculate the average value of a specific column
        int columnToAnalyze = 1; // Change this to the column number you want to analyze
        double totalValue = 0;

        for (int i = 1; i < totalRows; i++)
        {
            string[] values = lines[i].Split(',');
            totalValue += double.Parse(values[columnToAnalyze]);
        }

        double averageValue = totalValue / (totalRows - 1);
        Console.WriteLine($"Average value of column {columnToAnalyze}: {averageValue}");

        // Find the maximum value in a specific column
        double maxValue = lines.Skip(1)
                               .Select(row => double.Parse(row.Split(',')[columnToAnalyze]))
                               .Max();

        Console.WriteLine($"Maximum value in column {columnToAnalyze}: {maxValue}");
    }
}
