
using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        string titleCase = ToTitleCase(input);
        Console.WriteLine("Title Case: " + titleCase);
    }

    static string ToTitleCase(string input)
    {
        TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
        return textInfo.ToTitleCase(input.ToLower());
    }
}
