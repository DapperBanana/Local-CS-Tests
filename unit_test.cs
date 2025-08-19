
using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string text = "This is a sample text with #hashtags and #morehashtags #123!";
        
        // Use regular expression to find all hashtags in the text
        MatchCollection matches = Regex.Matches(text, @"#\w+");

        Console.WriteLine("Extracted hashtags:");
        foreach (Match match in matches)
        {
            Console.WriteLine(match.Value);
        }
    }
}
