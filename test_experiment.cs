
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string input = "Hello world, hello there! How are you today?";
        Dictionary<string, int> wordCounts = CountWords(input);
        
        foreach(var pair in wordCounts)
        {
            Console.WriteLine($"{pair.Key}: {pair.Value}");
        }
    }
    
    static Dictionary<string, int> CountWords(string input)
    {
        Dictionary<string, int> wordCounts = new Dictionary<string, int>();
        string[] words = input.Split(new char[] { ' ', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
        
        foreach(var word in words)
        {
            string lowercaseWord = word.ToLower();
            
            if(wordCounts.ContainsKey(lowercaseWord))
            {
                wordCounts[lowercaseWord]++;
            }
            else
            {
                wordCounts.Add(lowercaseWord, 1);
            }
        }
        
        return wordCounts;
    }
}
