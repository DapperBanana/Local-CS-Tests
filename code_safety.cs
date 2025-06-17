
using System;
using System.IO;

class Program
{
    static void Main()
    {
        string csvFile = "data.csv"; // Change this to the path to your CSV file

        try
        {
            using (var reader = new StreamReader(csvFile))
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
        catch (Exception e)
        {
            Console.WriteLine("An error occurred: " + e.Message);
        }
    }
}
