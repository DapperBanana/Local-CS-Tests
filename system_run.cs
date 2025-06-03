
using System;
using System.Globalization;

class Program
{
    public static string ToTitleCase(string input)
    {
        TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
        return textInfo.ToTitleCase(input);
    }

    static void Main()
    {
        string input = "hello, world!";
        string output = ToTitleCase(input);

        Console.WriteLine("Input: " + input);
        Console.WriteLine("Output: " + output);
    }
}
