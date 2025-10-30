
using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        string inputString = "hello world";
        string titleCaseString = ToTitleCase(inputString);
        
        Console.WriteLine(titleCaseString); // Output: Hello World
    }

    static string ToTitleCase(string input)
    {
        TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
        return textInfo.ToTitleCase(input);
    }
}
