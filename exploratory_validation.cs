
using System;
using Newtonsoft.Json;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a JSON string:");
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
            var json = JsonConvert.DeserializeObject(jsonString);
            return true;
        }
        catch (JsonReaderException)
        {
            return false;
        }
    }
}
