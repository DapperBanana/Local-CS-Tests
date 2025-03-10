
using System;
using System.IO;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string filePath = "textDocument.txt";
        string text = File.ReadAllText(filePath);

        // Define a regular expression for email addresses
        string pattern = @"([a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,})";

        // Find all matches
        MatchCollection matches = Regex.Matches(text, pattern);

        Console.WriteLine("Email addresses found in the text document:");

        // Print each match
        foreach (Match match in matches)
        {
            Console.WriteLine(match.Value);
        }
    }
}
