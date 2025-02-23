
using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        string input = "hello world";
        string output = ToTitleCase(input);
        Console.WriteLine(output);
    }

    static string ToTitleCase(string input)
    {
        TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
        return textInfo.ToTitleCase(input);
    }
}
