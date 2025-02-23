
using System;
using Newtonsoft.Json;

class Program
{
    static void Main()
    {
        string jsonString = "{ \"key\": \"value\" }";
        
        if(IsJSON(jsonString))
        {
            Console.WriteLine("The given string is a valid JSON.");
        }
        else
        {
            Console.WriteLine("The given string is not a valid JSON.");
        }
    }
    
    static bool IsJSON(string input)
    {
        try
        {
            var jsonObj = JsonConvert.DeserializeObject(input);
            return true;
        }
        catch(JsonReaderException)
        {
            return false;
        }
    }
}
