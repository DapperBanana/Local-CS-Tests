
using System;
using System.IO;
using Newtonsoft.Json.Linq;

class Program
{
    static void Main()
    {
        // Path to the JSON file
        string filePath = "data.json";

        // Check if the file exists
        if (!File.Exists(filePath))
        {
            Console.WriteLine("File not found.");
            return;
        }

        // Read the JSON file
        string jsonText = File.ReadAllText(filePath);

        // Parse the JSON string
        JObject json = JObject.Parse(jsonText);

        // Print key-value pairs
        foreach (var item in json)
        {
            Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
        }
    }
}
