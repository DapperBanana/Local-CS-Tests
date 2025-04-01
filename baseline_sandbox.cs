
using System;
using System.IO;

class Program
{
    static void Main()
    {
        string filePath = "data.csv";

        if (!File.Exists(filePath))
        {
            Console.WriteLine("File not found.");
            return;
        }

        using (var reader = new StreamReader(filePath))
        {
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split(',');

                foreach (var value in values)
                {
                    Console.Write(value + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
