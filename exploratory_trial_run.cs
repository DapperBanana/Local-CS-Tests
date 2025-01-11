
using System;
using System.IO;

class Program
{
    static void Main()
    {
        string filePath = "data.csv";

        try
        {
            string[] lines = File.ReadAllLines(filePath);

            // Iterate through each line in the CSV file
            foreach (string line in lines)
            {
                string[] values = line.Split(',');

                // Analyze data from CSV file
                Console.WriteLine("Value 1: " + values[0]);
                Console.WriteLine("Value 2: " + values[1]);
                Console.WriteLine("Value 3: " + values[2]);

                // Perform additional analysis as needed
            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("File not found: " + filePath);
        }
        catch (Exception e)
        {
            Console.WriteLine("An error occurred: " + e.Message);
        }
    }
}
