
using System;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        string csvFilePath = "sample.csv";

        // Read the CSV file into an array of lines
        string[] lines = File.ReadAllLines(csvFilePath);

        // Split the lines into an array of columns
        string[][] data = lines.Select(line => line.Split(',')).ToArray();

        // Get the number of rows and columns in the CSV file
        int numRows = data.Length;
        int numCols = data[0].Length;

        // Calculate the sum of a particular column (e.g. column 2)
        double sum = 0;
        for (int i = 1; i < numRows; i++)
        {
            sum += double.Parse(data[i][1]);
        }

        // Calculate the average of a particular column (e.g. column 2)
        double average = sum / (numRows - 1);

        // Output the results
        Console.WriteLine("Number of rows: " + numRows);
        Console.WriteLine("Number of columns: " + numCols);
        Console.WriteLine("Sum of column 2: " + sum);
        Console.WriteLine("Average of column 2: " + average);
    }
}
