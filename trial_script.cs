
using System;
using System.IO;
using Newtonsoft.Json.Linq;

class Program
{
    static void Main()
    {
        try
        {
            // Read the JSON file
            string jsonFilePath = "data.json";
            string jsonString = File.ReadAllText(jsonFilePath);

            // Parse the JSON string
            JObject jsonObj = JObject.Parse(jsonString);

            // Print key-value pairs
            foreach (var item in jsonObj)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}
