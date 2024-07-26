
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        string titleCase = ToTitleCase(input);
        Console.WriteLine("String in title case: " + titleCase);
    }

    static string ToTitleCase(string input)
    {
        string titleCase = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(input.ToLower());
        return titleCase;
    }
}
