
using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string text = "This is a #sample text with #hashtags #programming #csharp";

        var hashtags = ExtractHashtags(text);

        foreach (var hashtag in hashtags)
        {
            Console.WriteLine(hashtag);
        }
    }

    static List<string> ExtractHashtags(string text)
    {
        List<string> hashtags = new List<string>();

        string pattern = @"\B#\w+";
        Regex regex = new Regex(pattern);

        MatchCollection matches = regex.Matches(text);

        foreach (Match match in matches)
        {
            hashtags.Add(match.Value);
        }

        return hashtags;
    }
}
