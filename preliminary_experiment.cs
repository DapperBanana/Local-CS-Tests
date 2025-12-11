using System;
using Newtonsoft.Json;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a string to check if it is valid JSON:");
        string input = Console.ReadLine();

        bool isValidJson = IsValidJson(input);
        Console.WriteLine($"Is valid JSON: {isValidJson}");
    }

    static bool IsValidJson(string strInput)
    {
        if (string.IsNullOrWhiteSpace(strInput))
            return false;

        strInput = strInput.Trim();

        // Check if it is JSON object or array
        if ((!strInput.StartsWith("{") || !strInput.EndsWith("}")) &&
            (!strInput.StartsWith("[") || !strInput.EndsWith("]")))
        {
            return false;
        }

        try
        {
            var obj = JsonConvert.DeserializeObject(strInput);
            return true;
        }
        catch (JsonReaderException)
        {
            return false;
        }
        catch (JsonSerializationException)
        {
            return false;
        }
        catch
        {
            return false;
        }
    }
}