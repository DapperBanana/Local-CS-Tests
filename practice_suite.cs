
using System;
using System.Text.Json;

class Program
{
    static void Main()
    {
        string jsonString = "{\"name\": \"John\", \"age\": 30}";
        
        try
        {
            JsonDocument.Parse(jsonString);
            Console.WriteLine("The given string is a valid JSON.");
        }
        catch (JsonException)
        {
            Console.WriteLine("The given string is not a valid JSON.");
        }
    }
}
