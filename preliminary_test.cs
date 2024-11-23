
using System;
using Newtonsoft.Json.Linq;

class Program
{
    static void Main()
    {
        // Get the input string from the user
        Console.WriteLine("Enter a JSON string:");
        string jsonString = Console.ReadLine();

        // Check if the input is a valid JSON
        try
        {
            JToken.Parse(jsonString);
            Console.WriteLine("The input is a valid JSON.");
        }
        catch (Exception)
        {
            Console.WriteLine("The input is not a valid JSON.");
        }
    }
}
