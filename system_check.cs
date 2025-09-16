
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string inputString = "Hello world hello C# world hello";
        
        // Split the input string into words
        string[] words = inputString.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        // Create a dictionary to store word occurrences
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

        // Display the word counts
        foreach (KeyValuePair<string, int> pair in wordCount)
        {
            Console.WriteLine("{0}: {1}", pair.Key, pair.Value);
        }
    }
}
