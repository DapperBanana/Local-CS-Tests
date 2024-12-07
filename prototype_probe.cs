
using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a string:");
        string input = Console.ReadLine();

        TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
        string titleCase = textInfo.ToTitleCase(input);

        Console.WriteLine("String in title case: " + titleCase);
    }
}
