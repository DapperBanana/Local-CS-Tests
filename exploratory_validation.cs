
using System;
using System.IO;

class Program
{
    static void Main()
    {
        string filePath = "data.csv"; // Path to the CSV file

        using (StreamReader reader = new StreamReader(filePath))
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
}
