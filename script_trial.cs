
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

    public string GenerateSentence(int length)
    {
        string currentWord = chain.Keys.ToList()[rand.Next(chain.Keys.Count)];
        string sentence = currentWord;

        for (int i = 0; i < length; i++)
        {
            if (chain.ContainsKey(currentWord))
            {
                List<string> possibleNextWords = chain[currentWord];
                currentWord = possibleNextWords[rand.Next(possibleNextWords.Count)];
                sentence += " " + currentWord;
            }
            else
            {
                currentWord = chain.Keys.ToList()[rand.Next(chain.Keys.Count)];
                sentence += " " + currentWord;
            }
        }

        return sentence;
    }
}

class Program
{
    static void Main()
    {
        string input = "This is a simple example sentence for training the Markov chain model";
        string[] words = input.Split(' ');

        MarkovChain mc = new MarkovChain();
        mc.Train(words);

        string randomSentence = mc.GenerateSentence(10);
        Console.WriteLine(randomSentence);
    }
}
