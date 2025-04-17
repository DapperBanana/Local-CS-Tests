
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string inputText = "The quick brown fox jumps over the lazy dog";
        int chainLength = 2;

        Dictionary<string, List<string>> markovChain = BuildMarkovChain(inputText, chainLength);
        string sentence = GenerateRandomSentence(markovChain, chainLength);

        Console.WriteLine(sentence);
    }

    static Dictionary<string, List<string>> BuildMarkovChain(string inputText, int chainLength)
    {
        string[] words = inputText.Split(' ');
        Dictionary<string, List<string>> markovChain = new Dictionary<string, List<string>>();

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

    static string GenerateRandomSentence(Dictionary<string, List<string>> markovChain, int chainLength)
    {
        Random random = new Random();
        string[] words = markovChain.Keys.ToArray();
        string currentKey = words[random.Next(words.Length)];
        string sentence = currentKey;

        for (int i = 0; i < 10; i++) // Generate a sentence of maximum length 10
        {
            List<string> nextWords = markovChain[currentKey];
            string nextWord = nextWords[random.Next(nextWords.Count)];
            sentence += " " + nextWord;
            currentKey = GetNextKey(currentKey, nextWord, chainLength);
        }

        return sentence;
    }

    static string GetNextKey(string currentKey, string nextWord, int chainLength)
    {
        string[] keyWords = currentKey.Split(' ');
        string nextKey = "";

        for (int i = 1; i < chainLength; i++)
        {
            nextKey += keyWords[i] + " ";
        }

        nextKey += nextWord;

        return nextKey;
    }
}
