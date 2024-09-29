
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string input = "This is a sample string to count the occurrences of each word in this string sample.";

        string[] words = input.Split(' ');

        Dictionary<string, int> wordCount = new Dictionary<string, int>();

        foreach (string word in words)
        {
            string cleanedWord = word.Trim('.',',','!','?').ToLower();

            if (wordCount.ContainsKey(cleanedWord))
            {
                wordCount[cleanedWord]++;
            }
            else
            {
                wordCount[cleanedWord] = 1;
            }
        }

        foreach (var pair in wordCount)
        {
            Console.WriteLine("{0}: {1}", pair.Key, pair.Value);
        }
    }
}
