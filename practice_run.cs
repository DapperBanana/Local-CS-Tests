
using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string input = "Hello, World! How are you?";
        string strippedInput = RemovePunctuation(input);
        
        Console.WriteLine("Original string: " + input);
        Console.WriteLine("String without punctuation: " + strippedInput);
    }

    static string RemovePunctuation(string input)
    {
        return Regex.Replace(input, @"[^\w\s]", "");
    }
}
