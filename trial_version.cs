
using System;
using System.IO;

class Program
{
    static void Main()
    {
        // Load data from a CSV file
        string filePath = "data.csv";
        string[] lines = File.ReadAllLines(filePath);

        // Analyze data
        int totalRows = lines.Length;
        double totalValue = 0;

        foreach (string line in lines)
        {
            string[] values = line.Split(',');
            double value = double.Parse(values[1]); // Assuming the value is in the second column

            totalValue += value;
        }

        double averageValue = totalValue / totalRows;

        // Output results
        Console.WriteLine("Total number of rows: " + totalRows);
        Console.WriteLine("Total value: " + totalValue);
        Console.WriteLine("Average value: " + averageValue);
    }
}
