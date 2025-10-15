
using System;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        // Read data from CSV file
        string[] lines = File.ReadAllLines("data.csv");

        // Analyze data
        int totalRows = lines.Length;
        int totalColumns = lines[0].Split(',').Length;
        int totalValues = lines.SelectMany(line => line.Split(',')).Count();

        Console.WriteLine($"Total rows: {totalRows}");
        Console.WriteLine($"Total columns: {totalColumns}");
        Console.WriteLine($"Total values: {totalValues}");

        // Additional analysis logic can be added here

        // Display data
        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }
    }
}
