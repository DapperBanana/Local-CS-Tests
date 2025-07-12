
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        string input = "hello world hello again world";
        Dictionary<string, int> wordCount = CountWords(input);

        foreach (var pair in wordCount)
        {
            Console.WriteLine("{0}: {1}", pair.Key, pair.Value);
        }
    }

    static Dictionary<string, int> CountWords(string input)
    {
        Dictionary<string, int> wordCount = new Dictionary<string, int>();

        string[] words = input.Split(' ');

        foreach (string word in words)
        {
            if (wordCount.ContainsKey(word))
            {
                wordCount[word]++;
            }
            else
            {
                wordCount[word] = 1;
            }
        }

        return wordCount;
    }
}
