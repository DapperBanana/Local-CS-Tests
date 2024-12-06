
using System;
using System.IO;
using Newtonsoft.Json.Linq;

class Program
{
    static void Main()
    {
        string filePath = "sample.json"; // Path to your JSON file

        try
        {
            string jsonString = File.ReadAllText(filePath);
            JObject jsonObject = JObject.Parse(jsonString);

            foreach (var item in jsonObject)
            {
                Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }
}
