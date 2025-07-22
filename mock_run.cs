
using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string text = "Hello world! This is a #sample text with #hashtags #csharp #programming.";

        var hashtags = ExtractHashtags(text);

        foreach (var hashtag in hashtags)
        {
            Console.WriteLine(hashtag);
        }
    }

    static string[] ExtractHashtags(string text)
    {
        Regex regex = new Regex(@"(?<=#)\w+");
        var matches = regex.Matches(text);

        string[] hashtags = new string[matches.Count];
        for (int i = 0; i < matches.Count; i++)
        {
            hashtags[i] = matches[i].Value;
        }

        return hashtags;
    }
}
