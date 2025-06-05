
using System;
using System.IO;
using Newtonsoft.Json.Linq;

class Program
{
    static void Main()
    {
        // Read JSON file
        string jsonFilePath = "data.json";
        string jsonContent = File.ReadAllText(jsonFilePath);

        // Parse JSON content
        JObject jsonObject = JObject.Parse(jsonContent);

        // Print key-value pairs
        foreach (var property in jsonObject.Properties())
        {
            Console.WriteLine($"{property.Name}: {property.Value}");
        }
    }
}
