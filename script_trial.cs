
using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string input = "Hello, World! This is a test string.";

        string result = RemovePunctuation(input);

        Console.WriteLine("Original string: " + input);
        Console.WriteLine("String with punctuation removed: " + result);
    }

    static string RemovePunctuation(string input)
    {
        return Regex.Replace(input, @"[\p{P}-[.,]]", "");
    }
}
