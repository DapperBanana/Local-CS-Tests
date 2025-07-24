
using System;
using System.IO;

class Program
{
    static void Main()
    {
        // Change the path to your CSV file
        string filePath = "data.csv";

        try
        {
            using (StreamReader sr = new StreamReader(filePath))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] values = line.Split(',');
                    foreach (string value in values)
                    {
                        Console.Write(value + " ");
                    }
                    Console.WriteLine();
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error reading the file: " + ex.Message);
        }
    }
}
