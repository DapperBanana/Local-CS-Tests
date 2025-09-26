
using System;
using System.IO;

namespace ReadCSVFile
{
    class Program
    {
        static void Main(string[] args)
        {
            // Path to the CSV file
            string filePath = "data.csv";

            // Check if the file exists
            if (File.Exists(filePath))
            {
                // Read the CSV file
                string[] lines = File.ReadAllLines(filePath);

                // Print the contents of the CSV file
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            else
            {
                Console.WriteLine("File not found.");
            }
        }
    }
}
