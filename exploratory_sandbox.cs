
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string text = System.IO.File.ReadAllText("text.txt");

        // Define a regular expression for email addresses
        Regex regex = new Regex(@"\b[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Z|a-z]{2,}\b");

        // Find all matches in the text
        MatchCollection matches = regex.Matches(text);

        // Display all email addresses found in the text
        foreach (Match match in matches)
        {
            Console.WriteLine(match.Value);
        }
    }
}
