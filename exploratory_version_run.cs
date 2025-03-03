
using System;
using System.IO;

class Program
{
    static void Main()
    {
        string filePath = "data.csv";

        if(File.Exists(filePath))
        {
            using (StreamReader reader = new StreamReader(filePath))
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
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}
