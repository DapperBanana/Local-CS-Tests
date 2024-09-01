
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Define the transition probabilities for the Markov chain
        Dictionary<string, List<string>> chain = new Dictionary<string, List<string>>()
        {
            { "I", new List<string> { "like", "love", "am", "enjoy" } },
            { "like", new List<string> { "to", "the", "pizza" } },
            { "to", new List<string> { "eat" } },
            { "eat", new List<string> { "pizza" } },
            { "love", new List<string> { "coding" } },
            { "coding", new List<string> { "in", "C#" } },
            { "in", new List<string> { "Markov", "the" } },
            { "Markov", new List<string> { "chains" } },
            { "chains", new List<string> { "." } },
            { "the", new List<string> { "world" } },
            { "world", new List<string> { "." } },
            { "am", new List<string> { "a" } },
            { "a", new List<string> { "programmer" } },
            { "programmer", new List<string> { "." } },
            { "enjoy", new List<string> { "programming" } },
            { "programming", new List<string> { "." } },
            { ".", new List<string> { "I" } }
        };

        Random rand = new Random();
        string currentWord = "I";
        string sentence = currentWord;

        for (int i = 0; i < 10; i++) // Generate a sentence with 10 words
        {
            List<string> nextWords = chain[currentWord];
            currentWord = nextWords[rand.Next(nextWords.Count)];
            sentence += " " + currentWord;
        }

        Console.WriteLine(sentence);
    }
}

