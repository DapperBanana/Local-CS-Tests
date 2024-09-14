
using System;
using System.IO;
using Newtonsoft.Json.Linq;

class Program
{
    static void Main(string[] args)
    {
        string jsonFilePath = "data.json";

        if (File.Exists(jsonFilePath))
        {
            string jsonContent = File.ReadAllText(jsonFilePath);
            JObject jsonObject = JObject.Parse(jsonContent);

            foreach (var item in jsonObject)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
        else
        {
            Console.WriteLine("JSON file not found.");
        }
    }
}
