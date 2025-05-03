
using Newtonsoft.Json;
using System;

class Program
{
    static void Main()
    {
        string jsonString = "{\"name\":\"John\",\"age\":30,\"city\":\"New York\"}";

        if (IsValidJson(jsonString))
        {
            Console.WriteLine("The given string is a valid JSON.");
        }
        else
        {
            Console.WriteLine("The given string is not a valid JSON.");
        }
    }

    static bool IsValidJson(string input)
    {
        input = input.Trim();
        if ((input.StartsWith("{") && input.EndsWith("}")) || (input.StartsWith("[") && input.EndsWith("]")))
        {
            try
            {
                var obj = JsonConvert.DeserializeObject(input);
                return true;
            }
            catch
            {
                return false;
            }
        }
        else
        {
            return false;
        }
    }
}
