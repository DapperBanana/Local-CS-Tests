using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string inputText = "This is a sample text with #hashtags. Let's see how #hashtags are extracted, including #CSharp and #2023!";
        List<string> hashtags = ExtractHashtags(inputText);

        Console.WriteLine("Extracted Hashtags:");
        foreach (var hashtag in hashtags)
        {
            Console.WriteLine(hashtag);
        }
    }

    static List<string> ExtractHashtags(string text)
    {
        var hashtags = new List<string>();
        Regex regex = new Regex(@"#\w+");
        MatchCollection matches = regex.Matches(text);

        foreach (Match match in matches)
        {
            hashtags.Add(match.Value);
        }

        return hashtags;
    }
}