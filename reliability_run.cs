
using System;
using System.IO;

class Program
{
    static void Main()
    {
        try
        {
            string filePath = "sample.csv";
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
        catch (Exception e)
        {
            Console.WriteLine("Error: " + e.Message);
        }
    }
}
