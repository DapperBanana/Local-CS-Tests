
using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        string input = "hello world";
        string titleCase = ToTitleCase(input);
        
        Console.WriteLine("Input: " + input);
        Console.WriteLine("Title Case: " + titleCase);
    }

    static string ToTitleCase(string input)
    {
        CultureInfo cultureInfo = CultureInfo.CurrentCulture;
        TextInfo textInfo = cultureInfo.TextInfo;
        return textInfo.ToTitleCase(input);
    }
}
