
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string text = "The quick brown fox jumps over the lazy dog";
        int chainLength = 2;
        int sentenceLength = 10;

        Dictionary<string, List<string>> markovChain = BuildMarkovChain(text, chainLength);

        Random random = new Random();
        string current = GetRandomStartingKey(markovChain, random);

        Console.Write(current);

        for (int i = chainLength; i < sentenceLength; i++)
        {
            List<string> nextWords = markovChain[current];
            string next = nextWords[random.Next(nextWords.Count)];
            Console.Write(" " + next);
            current = BuildNewKey(current, next, chainLength);
        }

        Console.WriteLine();
    }

    static Dictionary<string, List<string>> BuildMarkovChain(string text, int chainLength)
    {
        Dictionary<string, List<string>> markovChain = new Dictionary<string, List<string>>();
        string[] words = text.Split(' ');

        for (int i = 0; i < words.Length - chainLength; i++)
        {
            string key = "";
            for (int j = 0; j < chainLength; j++)
            {
                key += words[i + j] + " ";
            }
            key = key.Trim();

            if (!markovChain.ContainsKey(key))
            {
                markovChain[key] = new List<string>();
            }

            markovChain[key].Add(words[i + chainLength]);
        }

        return markovChain;
    }

    static string GetRandomStartingKey(Dictionary<string, List<string>> markovChain, Random random)
    {
        List<string> keys = new List<string>(markovChain.Keys);
        return keys[random.Next(keys.Count)];
    }

    static string BuildNewKey(string current, string next, int chainLength)
    {
        string[] words = current.Split(' ');
        string newKey = "";

        for (int i = 1; i < words.Length; i++)
        {
            newKey += words[i] + " ";
        }

        newKey += next;
        return newKey.Trim();
    }
}
