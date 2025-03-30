
using System;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

class Program
{
    static void Main()
    {
        string path = "data.json";

        if (File.Exists(path))
        {
            string jsonData = File.ReadAllText(path);
            JObject jsonObject = JObject.Parse(jsonData);

            foreach (var item in jsonObject)
            {
                Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
            }
        }
        else
        {
            Console.WriteLine("File not found!");
        }
    }
}
