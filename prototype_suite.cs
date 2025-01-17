
using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string input = "Hello, World! This is a sample string.";

        // Remove all punctuation from the input string
        string result = RemovePunctuation(input);

        Console.WriteLine($"Original string: {input}");
        Console.WriteLine($"String without punctuation: {result}");
    }

    static string RemovePunctuation(string input)
    {
        return Regex.Replace(input, "[^a-zA-Z0-9 ]", "");
    }
}
