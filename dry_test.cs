
using System;
using System.Collections.Generic;

class MarkovChain
{
    private Dictionary<string, List<string>> chain = new Dictionary<string, List<string>>();
    private Random rand = new Random();

    public void Train(string[] words)
    {
        for (int i = 0; i < words.Length - 1; i++)
        {
            string currentWord = words[i];
            string nextWord = words[i + 1];

            if (!chain.ContainsKey(currentWord))
            {
                chain[currentWord] = new List<string>();
            }

            chain[currentWord].Add(nextWord);
        }
    }

    public string GenerateSentence()
    {
        string currentWord = chain.Keys.ElementAt(rand.Next(chain.Count));
        string sentence = currentWord;

        while (chain.ContainsKey(currentWord))
        {
            List<string> possibleNextWords = chain[currentWord];
            currentWord = possibleNextWords[rand.Next(possibleNextWords.Count)];
            sentence += " " + currentWord;
        }

        return sentence;
    }
}

class Program
{
    static void Main()
    {
        string text = "This is a sample text for training the Markov chain model";
        string[] words = text.Split(' ');

        MarkovChain markovChain = new MarkovChain();
        markovChain.Train(words);

        string randomSentence = markovChain.GenerateSentence();
        Console.WriteLine(randomSentence);
    }
}

