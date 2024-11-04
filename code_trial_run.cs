
using Newtonsoft.Json;
using System;

class Program
{
    static void Main()
    {
        string jsonString = "{\"name\": \"John\", \"age\": 30}";
        
        try
        {
            dynamic json = JsonConvert.DeserializeObject(jsonString);
            Console.WriteLine("Given string is a valid JSON");
        }
        catch (JsonReaderException ex)
        {
            Console.WriteLine("Given string is not a valid JSON");
            Console.WriteLine(ex.Message);
        }
    }
}
