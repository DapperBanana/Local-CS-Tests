
using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string input = "Hello, World! This is a test string.";

        string result = RemovePunctuation(input);
        
        Console.WriteLine(result);
    }

    static string RemovePunctuation(string input)
    {
        return Regex.Replace(input, @"\p{P}+", "");
    }
}
