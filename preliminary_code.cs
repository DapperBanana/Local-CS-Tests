
using System;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        try
        {
            // Read the CSV file
            string[] lines = File.ReadAllLines("data.csv");

            // Analyze the data
            int totalRows = lines.Length;
            int totalColumns = lines[0].Split(',').Length;
            int totalValues = lines.SelectMany(line => line.Split(',')).Count();

            // Print out the results
            Console.WriteLine("Total rows: " + totalRows);
            Console.WriteLine("Total columns: " + totalColumns);
            Console.WriteLine("Total values: " + totalValues);
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
    }
}
