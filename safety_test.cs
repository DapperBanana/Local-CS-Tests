using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace CsvDataAnalysis
{
    class Program
    {
        // Define a class to represent each row in the CSV
        public class DataRecord
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public double Score { get; set; }
        }

        static void Main(string[] args)
        {
            string filePath = "data.csv"; // Path to your CSV file

            try
            {
                // Read all lines from the CSV file
                var lines = File.ReadAllLines(filePath);

                if (lines.Length < 2)
                {
                    Console.WriteLine("CSV file does not contain data.");
                    return;
                }

                // Parse header to identify columns
                var headers = lines[0].Split(',');

                int nameIndex = Array.IndexOf(headers, "Name");
                int ageIndex = Array.IndexOf(headers, "Age");
                int scoreIndex = Array.IndexOf(headers, "Score");

                if (nameIndex == -1 || ageIndex == -1 || scoreIndex == -1)
                {
                    Console.WriteLine("CSV headers missing required columns.");
                    return;
                }

                var records = new List<DataRecord>();

                // Parse data rows
                for (int i = 1; i < lines.Length; i++)
                {
                    var fields = lines[i].Split(',');

                    if (fields.Length != headers.Length)
                        continue; // Skip malformed lines

                    try
                    {
                        var record = new DataRecord
                        {
                            Name = fields[nameIndex],
                            Age = int.Parse(fields[ageIndex], CultureInfo.InvariantCulture),
                            Score = double.Parse(fields[scoreIndex], CultureInfo.InvariantCulture)
                        };
                        records.Add(record);
                    }
                    catch
                    {
                        // Handle parsing errors if necessary
                        continue;
                    }
                }

                if (records.Count == 0)
                {
                    Console.WriteLine("No valid records found.");
                    return;
                }

                // Data analysis examples
                Console.WriteLine($"Total records: {records.Count}");
                Console.WriteLine($"Average age: {records.Average(r => r.Age):F2}");
                Console.WriteLine($"Average score: {records.Average(r => r.Score):F2}");
                var maxScoreRecord = records.OrderByDescending(r => r.Score).First();
                Console.WriteLine($"Highest score: {maxScoreRecord.Score} by {maxScoreRecord.Name}");
                var minScoreRecord = records.OrderBy(r => r.Score).First();
                Console.WriteLine($"Lowest score: {minScoreRecord.Score} by {minScoreRecord.Name}");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine($"File not found: {filePath}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading or processing the file: {ex.Message}");
            }
        }
    }
}