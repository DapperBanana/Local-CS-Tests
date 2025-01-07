
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string input = "I am a C# programming enthusiast. C# is a powerful language.";

        Dictionary<string, int> wordCount = new Dictionary<string, int>();

        string[] words = input.Split(new char[] { ' ', '.', ',', ';' }, StringSplitOptions.RemoveEmptyEntries);
        
        foreach (string word in words)
        {
            string lowerWord = word.ToLower();
            if (wordCount.ContainsKey(lowerWord))
            {
                wordCount[lowerWord]++;
            }
            else
            {
                wordCount[lowerWord] = 1;
            }
        }

        Console.WriteLine("Word count in the given string:");
        foreach (KeyValuePair<string, int> pair in wordCount)
        {
            Console.WriteLine("{0}: {1}", pair.Key, pair.Value);
        }
    }
}
