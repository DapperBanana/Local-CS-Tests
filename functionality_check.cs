
using System;
using System.IO;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        try
        {
            string filePath = "data.csv";
            List<string[]> data = new List<string[]>();

            using (var reader = new StreamReader(filePath))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string[] values = line.Split(',');
                    data.Add(values);
                }
            }

            Console.WriteLine("Data analysis:");
            Console.WriteLine("------------------------------------");

            foreach (var row in data)
            {
                foreach (var value in row)
                {
                    Console.Write(value + "\t");
                }
                Console.WriteLine();
            }

            // Add your data analysis code here

        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
    }
}
