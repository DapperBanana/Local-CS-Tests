
using System;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

class Program
{
    static void Main()
    {
        // Read the JSON file
        string json = File.ReadAllText("data.json");

        // Parse the JSON string
        JObject data = JObject.Parse(json);

        // Print each key-value pair
        foreach (var pair in data)
        {
            Console.WriteLine($"{pair.Key}: {pair.Value}");
        }
    }
}
