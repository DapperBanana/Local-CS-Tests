
using System;
using System.Collections.Generic;

class MarkovChain
{
    // Define the Markov chain transition probabilities
    private Dictionary<string, List<string>> transitionProbabilities = new Dictionary<string, List<string>>();

    public void Train(string[] sentences)
    {
        foreach (string sentence in sentences)
        {
            string[] words = sentence.Split(' ');
            for (int i = 0; i < words.Length - 1; i++)
            {
                string currentWord = words[i];
                string nextWord = words[i + 1];

                if (!transitionProbabilities.ContainsKey(currentWord))
                {
                    transitionProbabilities[currentWord] = new List<string>();
                }

                transitionProbabilities[currentWord].Add(nextWord);
            }
        }
    }

    public string GenerateSentence()
    {
        Random random = new Random();
        string currentWord = transitionProbabilities.Keys.ElementAt(random.Next(transitionProbabilities.Count));
        string result = currentWord;

        while (transitionProbabilities.ContainsKey(currentWord))
        {
            List<string> possibleWords = transitionProbabilities[currentWord];
            string nextWord = possibleWords[random.Next(possibleWords.Count)];
            result += " " + nextWord;
            currentWord = nextWord;
        }

        return result;
    }
}

class Program
{
    static void Main()
    {
        MarkovChain markovChain = new MarkovChain();

        // Sample sentences to train the Markov chain
        string[] sentences = {
            "I like to eat apples",
            "She enjoys reading books",
            "He plays basketball every day"
        };

        markovChain.Train(sentences);

        // Generate a random sentence using the Markov chain
        string randomSentence = markovChain.GenerateSentence();
        Console.WriteLine(randomSentence);
    }
}
