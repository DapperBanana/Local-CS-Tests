
using System;
using Newtonsoft.Json.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a JSON string:");
        string jsonString = Console.ReadLine();

        if (IsValidJson(jsonString))
        {
            Console.WriteLine("Valid JSON string.");
        }
        else
        {
            Console.WriteLine("Invalid JSON string.");
        }
    }

    static bool IsValidJson(string jsonString)
    {
        try
        {
            JToken.Parse(jsonString);
            return true;
        }
        catch (Newtonsoft.Json.JsonReaderException)
        {
            return false;
        }
    }
}
