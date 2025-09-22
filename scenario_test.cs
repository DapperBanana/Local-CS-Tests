
using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a string:");
        string input = Console.ReadLine();

        string titleCase = ToTitleCase(input);

        Console.WriteLine("Title case version: " + titleCase);
    }

    static string ToTitleCase(string input)
    {
        TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
        return textInfo.ToTitleCase(input);
    }
}
