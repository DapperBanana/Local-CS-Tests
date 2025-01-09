
using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string text = @"Hello, my email address is example@example.com. Please contact me at this address.";

        // Define a regular expression for email addresses
        string pattern = @"[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}";

        // Find all matches in the text
        MatchCollection matches = Regex.Matches(text, pattern);

        // Print all email addresses found
        foreach (Match match in matches)
        {
            Console.WriteLine(match.Value);
        }
    }
}
