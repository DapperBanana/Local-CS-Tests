
using System;
using System.Text.Json;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a JSON string to check:");
        string jsonString = Console.ReadLine();

        try
        {
            JsonDocument.Parse(jsonString);
            Console.WriteLine("The input is a valid JSON.");
        }
        catch (JsonException)
        {
            Console.WriteLine("The input is not a valid JSON.");
        }
    }
}
