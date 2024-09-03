
using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string input = "Hello, world! This is a test string. It has some punctuation, like commas, periods, and exclamation marks!";
        
        string result = RemovePunctuation(input);
        
        Console.WriteLine(result);
    }

    static string RemovePunctuation(string input)
    {
        return Regex.Replace(input, @"[^\w\s]", "");
    }
}
