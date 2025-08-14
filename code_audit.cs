
using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string text = "This is a sample text with #hashtags and #morehashtags #csharp";

        foreach (Match match in Regex.Matches(text, @"\B#\w+"))
        {
            Console.WriteLine(match.Value);
        }
    }
}
