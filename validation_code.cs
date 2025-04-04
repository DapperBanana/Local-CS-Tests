
using System;
using System.IO;

class Program
{
    static void Main()
    {
        // Specify the file path of the CSV file
        string filePath = "example.csv";

        // Read the content of the CSV file
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
