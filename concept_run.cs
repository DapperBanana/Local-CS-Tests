
using System;
using System.IO;
using Newtonsoft.Json.Linq;

class Program
{
    static void Main()
    {
        string filePath = @"sample.json";

        if (File.Exists(filePath))
        {
            string json = File.ReadAllText(filePath);
            JObject jsonObject = JObject.Parse(json);

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
