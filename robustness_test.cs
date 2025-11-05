
using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        string result = RemovePunctuation(input);

        Console.WriteLine("String without punctuation: " + result);
    }

    static string RemovePunctuation(string input)
    {
        return Regex.Replace(input, "[^a-zA-Z0-9 ]", "");
    }
}
