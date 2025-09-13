
using System;
using System.IO;

class Program
{
    static void Main()
    {
        try
        {
            string filePath = "data.csv";

            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
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
            Console.WriteLine("An error occurred: " + ex.Message);
        }
    }
}
