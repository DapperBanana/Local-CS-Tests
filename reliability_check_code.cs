
using System;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

class Program
{
    static void Main()
    {
        string jsonFilePath = "data.json";
        
        try
        {
            string jsonContent = File.ReadAllText(jsonFilePath);
            JObject json = JObject.Parse(jsonContent);
            
            foreach (var pair in json)
            {
                Console.WriteLine("Key: {0}, Value: {1}", pair.Key, pair.Value);
            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("File not found.");
        }
        catch (JsonReaderException)
        {
            Console.WriteLine("Invalid JSON format.");
        }
    }
}
