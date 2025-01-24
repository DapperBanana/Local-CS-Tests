
using System;
using System.IO;
using Newtonsoft.Json.Linq;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            // Read the JSON file
            string json = File.ReadAllText("sample.json");

            // Parse the JSON string
            JObject jsonObj = JObject.Parse(json);

            // Print the key-value pairs
            foreach (var item in jsonObj)
            {
                Console.WriteLine(item.Key + ": " + item.Value);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}
