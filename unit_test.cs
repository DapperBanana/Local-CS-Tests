
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string inputText = "The quick brown fox jumps over the lazy dog";
        Dictionary<string, List<string>> markovChain = BuildMarkovChain(inputText.Split(' '));

        string generatedSentence = GenerateSentence(markovChain);
        Console.WriteLine(generatedSentence);
    }

    static Dictionary<string, List<string>> BuildMarkovChain(string[] words)
    {
        Dictionary<string, List<string>> markovChain = new Dictionary<string, List<string>>();

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

        return markovChain;
    }

    static string GenerateSentence(Dictionary<string, List<string>> markovChain)
    {
        Random random = new Random();
        string currentWord = markovChain.Keys.ElementAt(random.Next(markovChain.Count));
        string generatedSentence = currentWord;

        for (int i = 0; i < 10; i++) // Change the number of words in the generated sentence
        {
            if (markovChain.ContainsKey(currentWord))
            {
                List<string> nextWords = markovChain[currentWord];
                string nextWord = nextWords[random.Next(nextWords.Count)];
                generatedSentence += " " + nextWord;
                currentWord = nextWord;
            }
            else
            {
                break;
            }
        }

        return generatedSentence;
    }
}
