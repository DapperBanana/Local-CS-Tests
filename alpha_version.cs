
using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string text = "This is a sample text with #hashtags and #morehashtags";
        
        // Use regular expression to find all hashtags in the text
        Regex regex = new Regex(@"#\w+");
        MatchCollection matches = regex.Matches(text);
        
        // Print out all the hashtags found
        foreach (Match match in matches)
        {
            Console.WriteLine(match.Value);
        }
    }
}
