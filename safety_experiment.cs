
using System;
using System.IO;

class Program
{
    static void Main()
    {
        // Path to the CSV file
        string filePath = @"C:\Users\user\Documents\file.csv";
        
        // Check if the file exists
        if (!File.Exists(filePath))
        {
            Console.WriteLine("File not found.");
            return;
        }
        
        // Read the file and print its contents
        string[] lines = File.ReadAllLines(filePath);
        foreach (string line in lines)
        {
            string[] values = line.Split(',');
            foreach (string value in values)
            {
                Console.Write(value + "\t");
            }
            Console.WriteLine();
        }
    }
}
