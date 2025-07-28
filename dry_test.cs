
using System;
using System.IO;

class Program
{
    static void Main()
    {
        // Path to the CSV file
        string filePath = "sample.csv";

        try
        {
            // Read the CSV file
            using (StreamReader reader = new StreamReader(filePath))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string[] values = line.Split(',');

                    foreach (string value in values)
                    {
                        Console.Write(value + "\t");
                    }
                    Console.WriteLine();
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}
