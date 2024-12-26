
using System;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        string filePath = "data.csv";

        // Read the CSV file
        string[] lines = File.ReadAllLines(filePath);

        // Get headers
        string[] headers = lines[0].Split(',');

        // Get data excluding headers
        string[][] data = lines.Skip(1)
                               .Select(line => line.Split(','))
                               .ToArray();

        // Output the data
        Console.WriteLine("Data Analysis of CSV File:");
        Console.WriteLine($"Number of Records: {data.Length}");

        // Analyze the data
        foreach (string[] record in data)
        {
            // Perform analysis here, for example, calculate the average of a specific column
            double average = record.Select(double.Parse).Average();
            Console.WriteLine($"Average: {average}");
        }
    }
}
