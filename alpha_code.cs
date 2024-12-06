
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        string input = "hello world hello";

        var wordCounts = CountWords(input);

        foreach (var wordCount in wordCounts)
        {
            Console.WriteLine($"'{wordCount.Key}': {wordCount.Value}");
        }
    }

    public static Dictionary<string, int> CountWords(string input)
    {
        Dictionary<string, int> wordCounts = new Dictionary<string, int>();

        string[] words = input.Split(' ');

        foreach (string word in words)
        {
            if (wordCounts.ContainsKey(word))
            {
                wordCounts[word]++;
            }
            else
            {
                wordCounts[word] = 1;
            }
        }

        return wordCounts;
    }
}
