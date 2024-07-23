
using System;
using System.IO;
using Newtonsoft.Json.Linq;

class Program
{
    static void Main()
    {
        // Read JSON file
        string jsonFilePath = "data.json";
        string jsonString = File.ReadAllText(jsonFilePath);

        // Parse JSON string to JObject
        JObject jsonObject = JObject.Parse(jsonString);

        // Loop through key-value pairs and print them
        foreach (var item in jsonObject)
        {
            string key = item.Key;
            string value = item.Value.ToString();
            Console.WriteLine($"{key}: {value}");
        }
    }
}
