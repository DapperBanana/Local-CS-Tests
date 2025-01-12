
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string text = "I love programming in C# because it is a powerful and versatile language.";

        // Create Markov chain dictionary
        Dictionary<string, List<string>> markovChain = new Dictionary<string, List<string>>();

        string[] words = text.Split(' ');

        // Build Markov chain
        for (int i = 0; i < words.Length - 1; i++)
        {
            if (!markovChain.ContainsKey(words[i]))
            {
                markovChain[words[i]] = new List<string>();
            }

            markovChain[words[i]].Add(words[i + 1]);
        }

        // Generate random sentence
        Random random = new Random();
        string currentWord = words[random.Next(words.Length)];
        string sentence = currentWord + " ";

        for (int i = 0; i < 10; i++)
        {
            if (markovChain.ContainsKey(currentWord))
            {
                List<string> nextWords = markovChain[currentWord];
                currentWord = nextWords[random.Next(nextWords.Count)];
                sentence += currentWord + " ";
            }
        }

        Console.WriteLine(sentence);
    }
}
