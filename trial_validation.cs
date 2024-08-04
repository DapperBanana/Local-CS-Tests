
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string text = "The quick brown fox jumps over the lazy dog. The lazy dog sleeps all day. The quick brown fox is very fast.";

        Dictionary<string, List<string>> markovChain = new Dictionary<string, List<string>>();

        string[] words = text.Split(' ');

        for (int i = 0; i < words.Length - 1; i++)
        {
            if (!markovChain.ContainsKey(words[i]))
            {
                markovChain[words[i]] = new List<string>();
            }
            markovChain[words[i]].Add(words[i + 1]);
        }

        string currentWord = words[new Random().Next(0, words.Length - 1)];

        Console.Write(currentWord + " ");

        for (int i = 0; i < 10; i++)
        {
            List<string> nextWords = markovChain[currentWord];
            string nextWord = nextWords[new Random().Next(0, nextWords.Count)];
            Console.Write(nextWord + " ");
            currentWord = nextWord;
        }

        Console.WriteLine();
    }
}
