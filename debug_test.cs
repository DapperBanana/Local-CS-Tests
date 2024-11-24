
using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string text = "This is a sample text with #hashtags and #morehashtags.";
        string pattern = @"#\w+";
        
        Regex regex = new Regex(pattern);

        MatchCollection matches = regex.Matches(text);

        Console.WriteLine("Hashtags found in the text:");

        foreach (Match match in matches)
        {
            Console.WriteLine(match.Value);
        }
    }
}
