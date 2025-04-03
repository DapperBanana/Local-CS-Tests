
using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string input = "Hello, World! How are you?";
        string result = RemovePunctuation(input);
        
        Console.WriteLine("Original string: " + input);
        Console.WriteLine("String without punctuation: " + result);
    }

    static string RemovePunctuation(string input)
    {
        return Regex.Replace(input, "[^A-Za-z0-9 ]", "");
    }
}
