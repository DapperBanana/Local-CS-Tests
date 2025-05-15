
using System;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

class Program
{
    static void Main()
    {
        string filePath = @"example.json";

        try
        {
            // Read the JSON file
            string json = File.ReadAllText(filePath);

            // Parse JSON into a JObject
            JObject jsonObject = JObject.Parse(json);

            // Iterate over each key-value pair and print them
            foreach (var item in jsonObject)
            {
                Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error reading JSON file: {ex.Message}");
        }
    }
}
