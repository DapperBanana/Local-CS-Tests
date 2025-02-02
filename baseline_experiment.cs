
using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        // Input string
        string input = "hello world";

        // Convert string to title case
        TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
        string titleCaseString = textInfo.ToTitleCase(input);

        // Output the title case string
        Console.WriteLine(titleCaseString);
    }
}
