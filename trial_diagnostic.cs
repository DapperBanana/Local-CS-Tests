
using System;
using System.IO;
using Newtonsoft.Json.Linq;

class Program
{
    static void Main()
    {
        // Read the JSON file
        string json = File.ReadAllText("data.json");

        // Parse the JSON data
        var jsonObj = JObject.Parse(json);

        // Print the key-value pairs
        foreach (var property in jsonObj.Properties())
        {
            Console.WriteLine($"{property.Name}: {property.Value}");
        }
    }
}
