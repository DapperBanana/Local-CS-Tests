
using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string text = "Hello everyone! Check out this #amazing #CSharp program for extracting #hashtags.";
        
        // Use regular expression to find all hashtags in the given text
        MatchCollection matches = Regex.Matches(text, @"#\w+");

        // Loop through the matches and print each hashtag
        foreach (Match match in matches)
        {
            Console.WriteLine(match.Value);
        }
    }
}
