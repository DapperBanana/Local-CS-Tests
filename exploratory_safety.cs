
using System;
using System.Text.RegularExpressions;
using System.IO;

class Program
{
    static void Main()
    {
        // Read the text file
        string text = File.ReadAllText("input.txt");
        
        // Define the regular expression for email addresses
        Regex regex = new Regex(@"\b[A-Z0-9._%+-]+@[A-Z0-9.-]+\.[A-Z]{2,}\b", RegexOptions.IgnoreCase);

        // Find all matches
        MatchCollection matches = regex.Matches(text);

        // Print all email addresses found
        foreach (Match match in matches)
        {
            Console.WriteLine(match.Value);
        }
    }
}
