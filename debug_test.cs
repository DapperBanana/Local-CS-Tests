
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
            Console.WriteLine("The input string is a valid JSON.");
        }
        else
        {
            Console.WriteLine("The input string is not a valid JSON.");
        }
    }

    public static bool IsValidJson(string json)
    {
        try
        {
            JToken.Parse(json);
            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }
}
