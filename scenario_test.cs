
using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string text = "This is a sample text with #hashtags and some #morehashtags";

        // Define the regex pattern for hashtags
        Regex regex = new Regex("#\\w+");

        // Find all matches in the text
        MatchCollection matches = regex.Matches(text);

        // Print out all hashtags found
        foreach (Match match in matches)
        {
            Console.WriteLine(match.Value);
        }
    }
}
