
using System;
using System.IO;
using Newtonsoft.Json.Linq;

class Program
{
    static void Main()
    {
        string filePath = "data.json";

        try
        {
            string json = File.ReadAllText(filePath);

            JObject jsonObject = JObject.Parse(json);

            foreach (var pair in jsonObject)
            {
                Console.WriteLine($"{pair.Key}: {pair.Value}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error reading JSON file: " + ex.Message);
        }
    }
}
