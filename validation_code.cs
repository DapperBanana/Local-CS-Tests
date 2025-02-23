
using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        string input = "hello world";
        string titleCase = ToTitleCase(input);
        Console.WriteLine(titleCase);
    }

    static string ToTitleCase(string input)
    {
        TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
        return textInfo.ToTitleCase(input);
    }
}
