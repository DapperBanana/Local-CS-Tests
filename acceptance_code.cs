
using System;
using Newtonsoft.Json.Linq;

class Program
{
    static void Main()
    {
        Console.Write("Enter a JSON string: ");
        string jsonString = Console.ReadLine();

        if (IsValidJson(jsonString))
        {
            Console.WriteLine("Valid JSON");
        }
        else
        {
            Console.WriteLine("Invalid JSON");
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
