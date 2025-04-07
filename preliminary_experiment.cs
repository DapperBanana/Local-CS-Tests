
using System;
using Newtonsoft.Json;
using System.IO;

class Program
{
    static void Main()
    {
        string jsonFilePath = "data.json";

        try
        {
            string json = File.ReadAllText(jsonFilePath);
            dynamic jsonObj = JsonConvert.DeserializeObject(json);

            foreach (var item in jsonObj)
            {
                Console.WriteLine($"Key: {item.Name}, Value: {item.Value}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error reading JSON file: {ex.Message}");
        }
    }
}
