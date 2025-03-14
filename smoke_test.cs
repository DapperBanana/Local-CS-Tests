
using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string input = "Hello, World! This is a test string.";

        // Remove all punctuation from the input string
        string result = RemovePunctuation(input);

        // Output the result
        Console.WriteLine(result);
    }

    static string RemovePunctuation(string input)
    {
        // Remove all punctuation using regular expression
        return Regex.Replace(input, @"[\p{P}\p{S}]", "");
    }
}
