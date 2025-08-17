
using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string text = "This is a sample text with #hashtags and #csharp";

        // Extract hashtags using regular expression
        Regex regex = new Regex(@"\B#\w+\b");
        MatchCollection matches = regex.Matches(text);

        // Print hashtags
        foreach(Match match in matches)
        {
            Console.WriteLine(match.Value);
        }
    }
}
