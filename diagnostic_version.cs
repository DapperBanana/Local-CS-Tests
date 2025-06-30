
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        // Read the text document
        string text = File.ReadAllText("input.txt");

        // Define the regular expression for extracting email addresses
        Regex regex = new Regex(@"\b[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Z|a-z]{2,}\b");

        // Find all matches
        MatchCollection matches = regex.Matches(text);

        // Print out the email addresses
        Console.WriteLine("Email addresses found in the document:");
        foreach (Match match in matches)
        {
            Console.WriteLine(match.Value);
        }
    }
}
