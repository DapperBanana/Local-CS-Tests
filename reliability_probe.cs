
using System;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        string filePath = "data.csv";

        // Read all lines from the CSV file
        string[] lines = File.ReadAllLines(filePath);

        // Get the headers from the first line
        string[] headers = lines[0].Split(',');

        // Remove the headers from the lines array
        lines = lines.Skip(1).ToArray();

        // Display the headers
        Console.WriteLine("Headers:");
        foreach (string header in headers)
        {
            Console.WriteLine(header);
        }

        // Analyze the data
        int totalRows = lines.Length;
        int totalColumns = headers.Length;

        Console.WriteLine($"Total rows: {totalRows}");
        Console.WriteLine($"Total columns: {totalColumns}");

        // Perform additional analysis here
        
        // Display the data
        foreach (string line in lines)
        {
            string[] data = line.Split(',');
            
            for (int i = 0; i < totalColumns; i++)
            {
                Console.WriteLine($"{headers[i]}: {data[i]}");
            }
        }
    }
}
