
using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main()
    {
        string text = File.ReadAllText("sampleText.txt"); // Read a sample text file
        string[] words = text.Split(' '); // Split the text into individual words

        Dictionary<string, List<string>> markovChain = new Dictionary<string, List<string>>();

        // Build the Markov chain from the sample text
        for (int i = 0; i < words.Length - 1; i++)
        {
            string currentWord = words[i];
            string nextWord = words[i + 1];

            if (!markovChain.ContainsKey(currentWord))
            {
                markovChain[currentWord] = new List<string>();
            }

            markovChain[currentWord].Add(nextWord);
        }

        // Generate a random sentence using the Markov chain
        Random rand = new Random();
        string current = words[rand.Next(words.Length)]; // Start with a random word

        Console.Write(current + " ");

        for (int i = 0; i < 10; i++) // Generate 10 words
        {
            List<string> nextWords = markovChain[current];
            string next = nextWords[rand.Next(nextWords.Count)];

            Console.Write(next + " ");
            current = next;
        }
    }
}
