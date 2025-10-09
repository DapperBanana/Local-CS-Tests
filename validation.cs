
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string input = "Hello world hello";
        
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
                wordCount[word] = 1;
            }
        }

        foreach (var pair in wordCount)
        {
            Console.WriteLine("{0} : {1}", pair.Key, pair.Value);
        }
    }
}
