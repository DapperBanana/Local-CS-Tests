
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string inputString = "Hello world hello";
        
        // Split the input string into words
        string[] words = inputString.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        
        // Create a dictionary to store word frequencies
        Dictionary<string, int> wordCount = new Dictionary<string, int>();
        
        // Count the occurrences of each word
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
        
        // Display the word frequencies
        foreach (var pair in wordCount)
        {
            Console.WriteLine($"{pair.Key}: {pair.Value}");
        }
    }
}
