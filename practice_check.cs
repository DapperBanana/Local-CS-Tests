using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string inputText = "Here's a sample text with #hashtags like #CSharp, #coding, and #100DaysOfCode!";
        var hashtags = ExtractHashtags(inputText);
        foreach (var hashtag in hashtags)
        {
            Console.WriteLine(hashtag);
        }
    }

    static List<string> ExtractHashtags(string text)
    {
        var hashtagList = new List<string>();
        // Pattern matches '#' followed by one or more word characters (letters, digits, underscores)
        var pattern = @"#\w+";

        foreach (Match match in Regex.Matches(text, pattern))
        {
            hashtagList.Add(match.Value);
        }

        return hashtagList;
    }
}