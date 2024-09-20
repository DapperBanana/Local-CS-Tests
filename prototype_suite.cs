
using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

class Program
{
    static void Main()
    {
        string jsonString = "{\"name\": \"John\", \"age\": 30}";

        try
        {
            JObject.Parse(jsonString);
            Console.WriteLine("The given string is a valid JSON.");
        }
        catch (JsonReaderException)
        {
            Console.WriteLine("The given string is not a valid JSON.");
        }
    }
}
