
using System;
using System.Collections.Generic;
using System.IO;

namespace CSVAnalysis
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = "data.csv";

            List<string[]> data = new List<string[]>();

            using (StreamReader reader = new StreamReader(filePath))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string[] values = line.Split(',');
                    data.Add(values);
                }
            }

            // Analyze the data
            Console.WriteLine("Total rows: " + data.Count);
            Console.WriteLine("Data analysis:");
            foreach (string[] row in data)
            {
                Console.WriteLine(string.Join(", ", row));
            }

            // Perform custom data analysis here

            Console.ReadLine();
        }
    }
}
