
using System;
using Newtonsoft.Json;

class Program
{
    static void Main()
    {
        string jsonString = "{\"name\": \"John\", \"age\": 30}";
        
        bool isValidJson = IsValidJson(jsonString);
        
        if(isValidJson)
        {
            Console.WriteLine("The given string is a valid JSON.");
        }
        else
        {
            Console.WriteLine("The given string is not a valid JSON.");
        }
    }

    static bool IsValidJson(string jsonString)
    {
        try
        {
            var parsedJson = JsonConvert.DeserializeObject(jsonString);
            return true;
        }
        catch
        {
            return false;
        }
    }
}
