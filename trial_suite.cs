
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        string inputString = "This is a simple example of a string with repeated words example";

        Dictionary<string, int> wordCount = CountOccurrences(inputString);

        foreach (var pair in wordCount)
        {
            Console.WriteLine("{0}: {1}", pair.Key, pair.Value);
        }
    }

    static Dictionary<string, int> CountOccurrences(string inputString)
    {
        Dictionary<string, int> wordCount = new Dictionary<string, int>();

        string[] words = inputString.Split(' ');

        foreach (string word in words)
        {
            string lowerWord = word.ToLower();

            if (wordCount.ContainsKey(lowerWord))
            {
                wordCount[lowerWord]++;
            }
            else
            {
                wordCount.Add(lowerWord, 1);
            }
        }

        return wordCount;
    }
}
