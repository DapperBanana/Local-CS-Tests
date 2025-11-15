
using System;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        // Specify the path to the CSV file
        string filePath = "data.csv";

        // Read all lines from the CSV file
        string[] lines = File.ReadAllLines(filePath);

        // Split each line by comma to get individual values
        var data = lines.Select(line => line.Split(','));

        // Calculate the total number of rows and columns
        int numRows = data.Count();
        int numCols = data.First().Length;

        Console.WriteLine($"Total rows: {numRows}");
        Console.WriteLine($"Total columns: {numCols}");

        // Analyze the data, for example calculate the sum of a particular column
        int sum = 0;
        foreach (var row in data)
        {
            if (int.TryParse(row[2], out int value))
            {
                sum += value;
            }
        }

        Console.WriteLine($"Sum of third column: {sum}");
    }
}
