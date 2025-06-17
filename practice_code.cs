
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string text = "hello world hello world";

        string[] words = text.Split(' ');

        Dictionary<string, int> wordCount = new Dictionary<string, int>();

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

        foreach (KeyValuePair<string, int> pair in wordCount)
        {
            Console.WriteLine($"{pair.Key}: {pair.Value}");
        }
    }
}
