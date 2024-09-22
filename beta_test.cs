
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a sentence:");
        string input = Console.ReadLine();

        string titleCase = ToTitleCase(input);
        Console.WriteLine("Title case output: " + titleCase);
    }

    static string ToTitleCase(string input)
    {
        string titleCase = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(input.ToLower());
        return titleCase;
    }
}
