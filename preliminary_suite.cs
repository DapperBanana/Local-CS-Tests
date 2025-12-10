using System;
using System.Text.Json;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a string to check if it's valid JSON:");
        string input = Console.ReadLine();

        if (IsValidJson(input))
        {
            Console.WriteLine("The string is valid JSON.");
        }
        else
        {
            Console.WriteLine("The string is NOT valid JSON.");
        }
    }

    public static bool IsValidJson(string jsonString)
    {
        if (string.IsNullOrWhiteSpace(jsonString))
            return false;

        try
        {
            JsonDocument.Parse(jsonString);
            return true;
        }
        catch (JsonException)
        {
            return false;
        }
    }
}