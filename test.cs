
using System;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

class Program
{
    static void Main()
    {
        // Read JSON file
        string json = File.ReadAllText("data.json");

        // Parse JSON data
        JObject data = JObject.Parse(json);

        // Print key-value pairs
        foreach (var pair in data)
        {
            Console.WriteLine($"{pair.Key}: {pair.Value}");
        }
    }
}
