
using System;
using System.IO;

class Program
{
    static void Main()
    {
        string filePath = "example.csv";
        
        try
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    // Split the line by comma and print each value
                    string[] values = line.Split(',');
                    foreach (string value in values)
                    {
                        Console.Write(value + " ");
                    }
                    Console.WriteLine();
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("An error occurred: " + e.Message);
        }
    }
}
