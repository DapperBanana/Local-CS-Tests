using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        // Specify the path to your text document
        string filePath = "path/to/your/document.txt";

        // Read all text from the file
        string text = File.ReadAllText(filePath);

        // Define a regex pattern to match email addresses
        string pattern = @"[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}";

        // Find all matches in the text
        MatchCollection matches = Regex.Matches(text, pattern);

        // Use a HashSet to avoid duplicate email addresses
        HashSet<string> emails = new HashSet<string>();

        foreach (Match match in matches)
        {
            emails.Add(match.Value);
        }

        // Output the list of email addresses
        Console.WriteLine("Extracted email addresses:");
        foreach (var email in emails)
        {
            Console.WriteLine(email);
        }
    }
}