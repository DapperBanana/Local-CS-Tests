
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        // Read the text document
        string text = File.ReadAllText("textdocument.txt");

        // Define the regex pattern for email addresses
        string pattern = @"\b[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Z|a-z]{2,}\b";
        
        // Find all matches of email addresses in the text
        MatchCollection matches = Regex.Matches(text, pattern);

        // Print out the extracted email addresses
        Console.WriteLine("Extracted email addresses:");
        foreach (Match match in matches)
        {
            Console.WriteLine(match.Value);
        }
    }
}
