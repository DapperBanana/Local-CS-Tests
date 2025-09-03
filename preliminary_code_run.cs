
using System;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        string filePath = "data.csv";
        string[] lines = File.ReadAllLines(filePath);

        // Calculate average of column 1
        double sum = 0;
        int count = 0;

        foreach (var line in lines)
        {
            string[] values = line.Split(',');
            if (values.Length > 0)
            {
                if (double.TryParse(values[0], out double num))
                {
                    sum += num;
                    count++;
                }
            }
        }

        double average = sum / count;

        Console.WriteLine($"Average of column 1: {average}");
    }
}

