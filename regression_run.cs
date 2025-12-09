using System;
using System.IO;
using Newtonsoft.Json.Linq;

class Program
{
    static void Main()
    {
        string filePath = "yourfile.json"; // Replace with your JSON file path

        try
        {
            string jsonContent = File.ReadAllText(filePath);
            JObject jsonObject = JObject.Parse(jsonContent);

            PrintJObject(jsonObject);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }

    static void PrintJObject(JObject jObject, string prefix = "")
    {
        foreach (var property in jObject.Properties())
        {
            if (property.Value.Type == JTokenType.Object)
            {
                Console.WriteLine($"{prefix}{property.Name}:");
                PrintJObject((JObject)property.Value, prefix + "  ");
            }
            else
            {
                Console.WriteLine($"{prefix}{property.Name}: {property.Value}");
            }
        }
    }
}