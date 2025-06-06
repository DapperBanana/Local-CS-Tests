
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string inputString = "the quick brown fox jumps over the lazy dog";

        string[] words = inputString.Split(' ');

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

        Console.WriteLine("Word\t\tCount");
        foreach (var pair in wordCount)
        {
            Console.WriteLine($"{pair.Key}\t\t{pair.Value}");
        }
    }
}
