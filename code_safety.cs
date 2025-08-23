
using System;
using Newtonsoft.Json;

class Program
{
    static void Main()
    {
        string json = "{\"name\": \"John\", \"age\": 30}";
        
        if (IsValidJson(json))
        {
            Console.WriteLine("The given string is a valid JSON.");
        }
        else
        {
            Console.WriteLine("The given string is not a valid JSON.");
        }
    }

    static bool IsValidJson(string json)
    {
        try
        {
            var obj = JsonConvert.DeserializeObject(json);
            return true;
        }
        catch (JsonReaderException)
        {
            return false;
        }
    }
}
