using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string text = "This is a sample text with #hashtags and some more #examples. Check out #ChatGPT!";
        List<string> hashtags = ExtractHashtags(text);
        
        foreach (var hashtag in hashtags)
        {
            Console.WriteLine(hashtag);
        }
    }

    static List<string> ExtractHashtags(string input)
    {
        var hashtags = new List<string>();
        var regex = new Regex(@"#\w+");
        var matches = regex.Matches(input);
        foreach (Match match in matches)
        {
            hashtags.Add(match.Value);
        }
        return hashtags;
    }
}