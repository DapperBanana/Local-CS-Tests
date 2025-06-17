
using System;
using System.Text.Json;

class Program
{
    static void Main()
    {
        string jsonString = "{\"name\": \"John\", \"age\": 30, \"city\": \"New York\"}";

        bool isValidJson = IsValidJson(jsonString);

        if (isValidJson)
        {
            Console.WriteLine("The given string is a valid JSON.");
        }
        else
        {
            Console.WriteLine("The given string is not a valid JSON.");
        }
    }

    static bool IsValidJson(string input)
    {
        try
        {
            JsonDocument.Parse(input);
            return true;
        }
        catch (JsonException)
        {
            return false;
        }
    }
}
