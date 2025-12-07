using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string filePath = "yourfile.csv"; // Replace with your CSV file path

        try
        {
            using (var reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error reading the CSV file: {ex.Message}");
        }
    }
}