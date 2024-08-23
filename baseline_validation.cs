
using System;
using Newtonsoft.Json;

class Program
{
    static void Main()
    {
        string input = "{\"name\": \"John\", \"age\": 30}";
        
        try
        {
            var json = JsonConvert.DeserializeObject(input);
            Console.WriteLine("Valid JSON");
        }
        catch (JsonReaderException)
        {
            Console.WriteLine("Invalid JSON");
        }
    }
}
