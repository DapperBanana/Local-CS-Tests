
using System;
using System.IO;

class Program
{
    static void Main()
    {
        string csvFilePath = "data.csv";

        if (File.Exists(csvFilePath))
        {
            using (var reader = new StreamReader(csvFilePath))
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
        else
        {
            Console.WriteLine("File not found: " + csvFilePath);
        }
    }
}
