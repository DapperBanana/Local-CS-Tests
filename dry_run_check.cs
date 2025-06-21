
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        string input = "Hello world hello hello World world";

        Dictionary<string, int> wordCounts = CountWords(input);

        foreach (var pair in wordCounts)
        {
            Console.WriteLine("{0}: {1}", pair.Key, pair.Value);
        }
    }

    static Dictionary<string, int> CountWords(string input)
    {
        string[] words = input.Split(' ');

        Dictionary<string, int> wordCounts = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);

        foreach (var word in words)
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
