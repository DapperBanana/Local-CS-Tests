using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string input = "This is a test. This test is simple!";
        Dictionary<string, int> wordCounts = CountWords(input);

        foreach (var pair in wordCounts)
        {
            Console.WriteLine($"'{pair.Key}': {pair.Value}");
        }
    }

    static Dictionary<string, int> CountWords(string text)
    {
        var counts = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);
        char[] delimiters = { ' ', '.', ',', '!', '?', ';', ':', '-', '\n', '\r', '\t' };

        var words = text.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

        foreach (var word in words)
        {
            string cleanWord = word.Trim();

            if (counts.ContainsKey(cleanWord))
            {
                counts[cleanWord]++;
            }
            else
            {
                counts[cleanWord] = 1;
            }
        }

        return counts;
    }
}