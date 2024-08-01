
using System;
using System.IO;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        // Read the text document
        string text = File.ReadAllText("textdocument.txt");

        // Define a regular expression for matching email addresses
        string pattern = @"\b[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Z|a-z]{2,}\b";
        Regex regex = new Regex(pattern);

        // Find all matches in the text
        MatchCollection matches = regex.Matches(text);

        // Print out all the email addresses found
        foreach (Match match in matches)
        {
            Console.WriteLine(match.Value);
        }
    }
}
