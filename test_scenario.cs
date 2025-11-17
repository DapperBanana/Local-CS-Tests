
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string[] words = { "I", "like", "to", "eat", "apples", "and", "bananas" };

        Dictionary<string, List<string>> transitions = new Dictionary<string, List<string>>();

        for (int i = 0; i < words.Length - 1; i++)
        {
            string currentWord = words[i];
            string nextWord = words[i + 1];

            if (!transitions.ContainsKey(currentWord))
            {
                transitions[currentWord] = new List<string>();
            }

            transitions[currentWord].Add(nextWord);
        }

        string sentence = GenerateSentence(transitions, words[0]);

        Console.WriteLine(sentence);
    }

    static string GenerateSentence(Dictionary<string, List<string>> transitions, string startWord)
    {
        string currentWord = startWord;
        string sentence = currentWord;

        Random rnd = new Random();

        while (transitions.ContainsKey(currentWord))
        {
            List<string> possibleNextWords = transitions[currentWord];

            currentWord = possibleNextWords[rnd.Next(possibleNextWords.Count)];
            sentence += " " + currentWord;
        }

        return sentence;
    }
}
