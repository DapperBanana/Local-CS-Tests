
using System;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        string filePath = "dataFile.csv";

        if (File.Exists(filePath))
        {
            string[] lines = File.ReadAllLines(filePath);

            double[] numbers = lines.Skip(1) // Skip header row
                                     .Select(line => double.Parse(line))
                                     .ToArray();

            double sum = numbers.Sum();
            double average = numbers.Average();
            double max = numbers.Max();
            double min = numbers.Min();

            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Average: {average}");
            Console.WriteLine($"Max: {max}");
            Console.WriteLine($"Min: {min}");
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}
