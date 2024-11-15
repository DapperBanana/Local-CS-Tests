
using System;
using System.Collections.Generic;

class MarkovChain
{
    private Dictionary<string, List<string>> chain = new Dictionary<string, List<string>>();

    public void AddSentence(string sentence)
    {
        string[] words = sentence.Split(' ');

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

    public string GenerateRandomSentence()
    {
        List<string> words = new List<string>();
        Random random = new Random();

        string currentWord = chain.Keys.ElementAt(random.Next(chain.Count));
        words.Add(currentWord);

        for (int i = 0; i < 10; i++)
        {
            if (chain.ContainsKey(currentWord))
            {
                List<string> nextWords = chain[currentWord];
                string nextWord = nextWords[random.Next(nextWords.Count)];
                words.Add(nextWord);
                currentWord = nextWord;
            }
            else
            {
                break;
            }
        }

        return string.Join(" ", words);
    }
}

class Program
{
    static void Main()
    {
        MarkovChain markovChain = new MarkovChain();
        markovChain.AddSentence("I like to eat pizza");
        markovChain.AddSentence("I like to listen to music");

        string randomSentence = markovChain.GenerateRandomSentence();
        Console.WriteLine(randomSentence);
    }
}
