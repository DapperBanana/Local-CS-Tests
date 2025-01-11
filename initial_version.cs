
using System;
using System.IO;

class Program
{
    static void Main()
    {
        string filePath = "data.csv";
        
        if (File.Exists(filePath))
        {
            string[] lines = File.ReadAllLines(filePath);

            // Analyze data
            int numLines = lines.Length;
            int numColumns = lines[0].Split(',').Length;
            
            Console.WriteLine($"Number of lines: {numLines}");
            Console.WriteLine($"Number of columns: {numColumns}");
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}
