
using System;
using Newtonsoft.Json.Linq;

class Program
{
    static void Main()
    {
        string jsonString = "{\"name\":\"John\",\"age\":30,\"city\":\"New York\"}";

        try
        {
            JObject.Parse(jsonString);
            Console.WriteLine("Valid JSON");
        }
        catch (Exception)
        {
            Console.WriteLine("Invalid JSON");
        }
    }
}
