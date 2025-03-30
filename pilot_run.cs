
using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string text = "This is a sample text with #hashtags and #morehashtags";

        // Use a regular expression to find all hashtags in the text
        Regex hashtagRegex = new Regex("#\\w+");
        MatchCollection matches = hashtagRegex.Matches(text);

        // Print out all the hashtags found in the text
        foreach (Match match in matches)
        {
            Console.WriteLine(match.Value);
        }
    }
}
