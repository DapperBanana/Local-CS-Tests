
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string input = "This is a sample string to count the occurrences of each word in this string";
        Dictionary<string, int> wordCount = CountWords(input);

        foreach (var pair in wordCount)
        {
            Console.WriteLine("{0}: {1}", pair.Key, pair.Value);
        }
    }

    static Dictionary<string, int> CountWords(string input)
    {
        string[] words = input.Split(' ');
        Dictionary<string, int> wordCount = new Dictionary<string, int>();

        foreach (string word in words)
        {
            string cleanWord = word.Trim(',', '.', ';', ':', '!', '?'); // Optionally remove punctuation if needed
            if (wordCount.ContainsKey(cleanWord))
            {
                wordCount[cleanWord]++;
            }
            else
            {
                wordCount[cleanWord] = 1;
            }
        }

        return wordCount;
    }
}
