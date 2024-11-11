
using System;
using System.IO;
using System.Linq;

namespace CSVAnalyzer
{
    class Program
    {
        static void Main(string[] args)
        {
            // Specify the path to the CSV file
            string filePath = "data.csv";

            // Check if the file exists
            if (!File.Exists(filePath))
            {
                Console.WriteLine("File not found.");
                return;
            }

            // Read all lines from the CSV file
            string[] lines = File.ReadAllLines(filePath);

            // Get the headers from the first line
            string[] headers = lines[0].Split(',');

            // Process the data
            for (int i = 1; i < lines.Length; i++)
            {
                string[] data = lines[i].Split(',');

                // Analyze the data here (e.g. calculate sum, average, count, etc.)
            }

            // Example: Calculate the average value of a specific column
            int columnIndex = Array.IndexOf(headers, "column_name");
            var averageValue = lines.Skip(1)
                                    .Select(line => int.Parse(line.Split(',')[columnIndex]))
                                    .Average();

            Console.WriteLine($"Average value: {averageValue}");

            // Additional analysis can be performed as needed

            Console.WriteLine("Data analysis complete.");
        }
    }
}
