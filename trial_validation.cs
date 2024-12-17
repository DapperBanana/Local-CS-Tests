
using System;
using System.IO;
using Newtonsoft.Json.Linq;

class Program
{
    static void Main()
    {
        // Read the JSON file
        string json = File.ReadAllText("data.json");
        
        // Parse the JSON string
        JObject jsonObj = JObject.Parse(json);
        
        // Iterate through each key-value pair and print them
        foreach (var item in jsonObj)
        {
            Console.WriteLine(item.Key + ": " + item.Value);
        }
    }
}
