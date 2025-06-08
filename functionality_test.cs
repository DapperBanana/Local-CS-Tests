
using System;
using System.IO;

class Program
{
    static void Main()
    {
        string filePath = "data.csv";

        try
        {
            using (StreamReader sr = new StreamReader(filePath))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] values = line.Split(',');

                    // Read data and perform analysis here
                    foreach (var value in values)
                    {
                        Console.WriteLine(value);
                        // Perform analysis on each value
                    }
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("Error reading file: " + e.Message);
        }
    }
}
