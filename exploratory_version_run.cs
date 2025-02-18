
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string text = "The quick brown fox jumps over the lazy dog.";
        int chainLength = 2;

        Dictionary<string, List<string>> markovChain = BuildMarkovChain(text, chainLength);

        string generatedSentence = GenerateSentence(markovChain, chainLength);
        Console.WriteLine(generatedSentence);
    }

    static Dictionary<string, List<string>> BuildMarkovChain(string text, int chainLength)
    {
        Dictionary<string, List<string>> markovChain = new Dictionary<string, List<string>>();
        string[] words = text.Split(' ');

        for (int i = 0; i < words.Length - chainLength; i++)
        {
            string key = string.Join(" ", words, i, chainLength);
            string value = words[i + chainLength];
            
            if (!markovChain.ContainsKey(key))
            {
                markovChain[key] = new List<string>();
            }
            markovChain[key].Add(value);
        }

        return markovChain;
    }

    static string GenerateSentence(Dictionary<string, List<string>> markovChain, int chainLength)
    {
        Random random = new Random();
        List<string> words = new List<string>();

        string startKey = markovChain.Keys.ElementAt(random.Next(markovChain.Count));
        string[] startWords = startKey.Split(' ');
        words.AddRange(startWords);

        while (markovChain.ContainsKey(startKey))
        {
            List<string> possibleNextWords = markovChain[startKey];
            string nextWord = possibleNextWords[random.Next(possibleNextWords.Count)];
            words.Add(nextWord);

            startKey = string.Join(" ", words.GetRange(words.Count - chainLength, chainLength));
        }

        return string.Join(" ", words);
    }
}
