
using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main()
    {
        string filePath = "data.csv";

        List<string[]> data = new List<string[]>();

        try
        {
            using (var reader = new StreamReader(filePath))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');
                    data.Add(values);
                }
            }

            Console.WriteLine("Data analysis:");
            Console.WriteLine($"Number of rows: {data.Count}");

            // Perform more analysis as needed, for example:
            // Calculate the average value of a specific column

            double sum = 0;
            foreach(var row in data)
            {
                sum += double.Parse(row[1]); // Assuming the values in the second column can be parsed to double
            }

            double average = sum / data.Count;
            Console.WriteLine($"Average value in column 2: {average}");

        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error reading file: {ex.Message}");
        }
    }
}
