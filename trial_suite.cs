
using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        string input = "hello world";
        string titleCase = ConvertToTitleCase(input);
        
        Console.WriteLine("Original string: " + input);
        Console.WriteLine("Title case string: " + titleCase);
    }

    static string ConvertToTitleCase(string input)
    {
        TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
        return textInfo.ToTitleCase(input);
    }
}
