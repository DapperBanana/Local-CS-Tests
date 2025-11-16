
using System;
using System.IO;
using Newtonsoft.Json.Linq;

class Program
{
    static void Main()
    {
        // Read the JSON file as a string
        string json = File.ReadAllText("data.json");

        // Parse the JSON string
        JObject obj = JObject.Parse(json);

        // Iterate through the key-value pairs and print them
        foreach (var pair in obj)
        {
            Console.WriteLine("{0}: {1}", pair.Key, pair.Value);
        }
    }
}
