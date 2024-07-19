
using System;
using System.IO;

namespace CSVReader
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = "data.csv";

            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);

                foreach (string line in lines)
                {
                    string[] values = line.Split(',');

                    // Display the data from the CSV file
                    Console.WriteLine("Name: {0}, Age: {1}, City: {2}", values[0], values[1], values[2]);

                    // Perform analysis on the data
                    // For example, find the average age
                }

                // Perform further analysis on the data if needed
            }
            else
            {
                Console.WriteLine("File not found: {0}", filePath);
            }
        }
    }
}
