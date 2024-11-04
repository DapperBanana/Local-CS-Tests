
using System;
using System.IO;

namespace CSVAnalyzer
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = "data.csv"; // Replace with your CSV file path

            if (!File.Exists(filePath))
            {
                Console.WriteLine("File not found.");
                return;
            }

            int columnToAnalyze = 1; // Column index (0-based) to calculate average for
            double sum = 0;
            int count = 0;

            using (var reader = new StreamReader(filePath))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');

                    if (columnToAnalyze < values.Length && double.TryParse(values[columnToAnalyze], out double value))
                    {
                        sum += value;
                        count++;
                    }
                }
            }

            if (count > 0)
            {
                double average = sum / count;
                Console.WriteLine($"Average value in column {columnToAnalyze}: {average}");
            }
            else
            {
                Console.WriteLine("No valid data found in the specified column.");
            }
        }
    }
}
