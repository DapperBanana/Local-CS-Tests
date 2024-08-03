
using System;
using System.IO;

class Program
{
    static void Main()
    {
        // Read the CSV file
        string[] lines = File.ReadAllLines("data.csv");

        // Analyze the data
        foreach (string line in lines)
        {
            string[] values = line.Split(',');

            // Assume data format: name, age, city, country
            string name = values[0];
            int age = int.Parse(values[1]);
            string city = values[2];
            string country = values[3];

            // Perform analysis
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"City: {city}");
            Console.WriteLine($"Country: {country}");
            Console.WriteLine();
        }
    }
}
