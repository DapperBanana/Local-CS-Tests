
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string input = "Hello World Hello World Count the occurrences of each word in this string";
        
        Dictionary<string, int> wordCount = new Dictionary<string, int>();
        
        string[] words = input.Split(' ');
        
        foreach (string word in words)
        {
            // Remove any punctuation from the word
            string cleanedWord = new string(word.Where(Char.IsLetter).ToArray());
            
            // Convert the word to lowercase for case-insensitive counting
            string lowercaseWord = cleanedWord.ToLower();
            
            if (wordCount.ContainsKey(lowercaseWord))
            {
                wordCount[lowercaseWord]++;
            }
            else
            {
                wordCount[lowercaseWord] = 1;
            }
        }
        
        foreach (var pair in wordCount)
        {
            Console.WriteLine($"'{pair.Key}': {pair.Value} occurrence(s)");
        }
    }
}
