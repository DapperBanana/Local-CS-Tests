
using System;
using System.IO;

class Program
{
    static void Main()
    {
        string csvFilePath = "data.csv";
        int columnToRead = 1; // Index of the column to read (0-based)

        // Ensure the CSV file exists
        if (!File.Exists(csvFilePath))
        {
            Console.WriteLine("File does not exist.");
            return;
        }

        // Read the CSV file
        string[] lines = File.ReadAllLines(csvFilePath);

        // Calculate the sum of the values in the specified column
        double sum = 0;
        foreach (string line in lines)
        {
            string[] columns = line.Split(',');
            
            if (columnToRead < columns.Length)
            {
                sum += Convert.ToDouble(columns[columnToRead]);
            }
        }

        Console.WriteLine("Sum of column {0} is: {1}", columnToRead, sum);
    }
}
