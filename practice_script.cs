
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string input = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.";

        Dictionary<string, int> wordCount = CountWords(input);

        foreach (var pair in wordCount)
        {
            Console.WriteLine("{0}: {1}", pair.Key, pair.Value);
        }
    }

    static Dictionary<string, int> CountWords(string input)
    {
        string[] words = input.Split(new char[] { ' ', ',', '.', '!', '?', ';', ':' }, StringSplitOptions.RemoveEmptyEntries);
        Dictionary<string, int> wordCount = new Dictionary<string, int>();

        foreach (string word in words)
        {
            string lowerCaseWord = word.ToLower();
            if (wordCount.ContainsKey(lowerCaseWord))
            {
                wordCount[lowerCaseWord]++;
            }
            else
            {
                wordCount[lowerCaseWord] = 1;
            }
        }

        return wordCount;
    }
}
