
using System;
using System.IO;

class Program
{
    static void Main()
    {
        // Path to the CSV file
        string filePath = "data.csv";

        // Check if the file exists
        if (!File.Exists(filePath))
        {
            Console.WriteLine("File not found.");
            return;
        }

        // Read the file and print its contents
        using (var reader = new StreamReader(filePath))
        {
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                string[] values = line.Split(',');

                foreach (var value in values)
                {
                    Console.Write(value + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
