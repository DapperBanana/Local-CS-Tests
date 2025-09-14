
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string input = "hello world hello stack overflow world hello";

        // Split the input string into an array of words
        string[] words = input.Split(' ');

        // Create a dictionary to store the count of each word
        Dictionary<string, int> wordCount = new Dictionary<string, int>();

        // Loop through each word in the array and update the count in the dictionary
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

        // Display the count of each word
        foreach (var pair in wordCount)
        {
            Console.WriteLine("{0}: {1}", pair.Key, pair.Value);
        }
    }
}
