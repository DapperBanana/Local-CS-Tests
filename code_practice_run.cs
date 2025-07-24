
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string input_text = "Hello world, this is a sample text for Markov chains. Markov chains are used for generating random sentences. This is an example of using Markov chains in C#.";

        int chainLength = 2;
        Dictionary<string, List<string>> markovDict = new Dictionary<string, List<string>>();

        string[] words = input_text.Split(' ');

        for (int i = 0; i < words.Length - chainLength; i++)
        {
            string key = "";
            for (int j = 0; j < chainLength; j++)
            {
                key += words[i + j] + " ";
            }
            key = key.Trim();

            if (!markovDict.ContainsKey(key))
            {
                markovDict[key] = new List<string>();
            }
            markovDict[key].Add(words[i + chainLength]);
        }

        string currentWord = words[new Random().Next(0, words.Length - chainLength)];

        string sentence = currentWord;

        for (int i = 0; i < 15; i++)
        {
            string nextWord = markovDict.ContainsKey(currentWord) ? markovDict[currentWord][new Random().Next(0, markovDict[currentWord].Count)] : words[new Random().Next(0, words.Length - 1)];
            sentence += " " + nextWord;
            currentWord = nextWord;
        }

        Console.WriteLine(sentence);
    }
}
