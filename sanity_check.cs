
using System;
using System.IO;

class Program
{
    static void Main()
    {
        try
        {
            string csvFilePath = "yourFile.csv";

            using (StreamReader reader = new StreamReader(csvFilePath))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string[] values = line.Split(',');

                    foreach (var value in values)
                    {
                        Console.Write(value + " ");
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
