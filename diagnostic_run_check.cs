
using System;
using System.Collections.Generic;

class WordCounter
{
    static void Main()
    {
        string input = "Hello world hello world programming hello world";
        Dictionary<string, int> wordCounts = CountWords(input);
        
        foreach (var pair in wordCounts)
        {
            Console.WriteLine("{0}: {1}", pair.Key, pair.Value);
        }
    }
    
    static Dictionary<string, int> CountWords(string input)
    {
        string[] words = input.Split(" ");
        Dictionary<string, int> wordCounts = new Dictionary<string, int>();
        
        foreach (string word in words)
        {
            string cleanedWord = word.ToLower().Trim(',', '.', '!', '?', '\"');
            
            if (wordCounts.ContainsKey(cleanedWord))
            {
                wordCounts[cleanedWord]++;
            }
            else
            {
                wordCounts[cleanedWord] = 1;
            }
        }
        
        return wordCounts;
    }
}
