
using System;
using System.IO;

class Program
{
    static void Main()
    {
        string filePath = "data.csv";

        try
        {
            using (var reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] values = line.Split(',');
                    
                    // Perform analysis on data
                    // For example, calculate the sum of a column
                    int sum = 0;
                    foreach (string value in values)
                    {
                        sum += Convert.ToInt32(value);
                    }
                    Console.WriteLine("Sum of values: " + sum);
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
    }
}
