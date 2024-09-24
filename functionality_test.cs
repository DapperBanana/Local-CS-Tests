
using System;
using System.IO;

class Program
{
    static void Main()
    {
        string csvFile = "data.csv";
        
        // Read the contents of the CSV file
        string[] lines = File.ReadAllLines(csvFile);

        // Display each line of the CSV file
        foreach (string line in lines)
        {
            string[] parts = line.Split(',');
            foreach (string part in parts)
            {
                Console.Write(part + " | ");
            }
            Console.WriteLine();
        }

        // Analyze the data
        int numRecords = lines.Length;
        int numFields = lines[0].Split(',').Length;

        Console.WriteLine($"Number of records: {numRecords}");
        Console.WriteLine($"Number of fields per record: {numFields}");
    }
}
