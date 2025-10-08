
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string input = "the quick brown fox jumps over the lazy dog";
        string[] words = input.Split(' ');

        Dictionary<string, int> wordCount = new Dictionary<string, int>();

        foreach (string word in words)
        {
            if (wordCount.ContainsKey(word))
            {
                wordCount[word]++;
            }
            else
            {
                wordCount.Add(word, 1);
            }
        }

        foreach (KeyValuePair<string, int> pair in wordCount)
        {
            Console.WriteLine("{0}: {1}", pair.Key, pair.Value);
        }
    }
}
