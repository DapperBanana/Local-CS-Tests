
using System;
using System.IO;

class Program
{
    static void Main()
    {
        string path = "sample.csv";

        try
        {
            using (StreamReader reader = new StreamReader(path))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
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
