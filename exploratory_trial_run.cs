
using Newtonsoft.Json;
using System;

class Program
{
    static void Main()
    {
        string jsonString = @"{ ""name"": ""John"", ""age"": 30 }";

        try
        {
            dynamic jsonObject = JsonConvert.DeserializeObject(jsonString);
            Console.WriteLine("The given string is a valid JSON.");
        }
        catch (JsonReaderException)
        {
            Console.WriteLine("The given string is not a valid JSON.");
        }
    }
}
