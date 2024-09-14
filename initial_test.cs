
using Newtonsoft.Json;

class Program
{
    static void Main()
    {
        string jsonString = "{ \"key\": \"value\" }";

        bool isValidJson = IsValidJson(jsonString);

        if (isValidJson)
        {
            Console.WriteLine("The given string is a valid JSON.");
        }
        else
        {
            Console.WriteLine("The given string is not a valid JSON.");
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
