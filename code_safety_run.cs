
using System;
using System.IO;
using Newtonsoft.Json.Linq;

class Program
{
    static void Main()
    {
        string jsonFilePath = "example.json"; // Replace with the path to your JSON file

        if (File.Exists(jsonFilePath))
        {
            string jsonText = File.ReadAllText(jsonFilePath);
            JObject jsonObject = JObject.Parse(jsonText);

            foreach (var pair in jsonObject)
            {
                Console.WriteLine($"{pair.Key}: {pair.Value}");
            }
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}
