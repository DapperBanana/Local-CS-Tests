
using System;
using System.Collections.Generic;

class MarkovChain
{
    static Random random = new Random();
    static Dictionary<string, List<string>> wordMap = new Dictionary<string, List<string>>();

    public static void AddWord(string word, string nextWord)
    {
        if (!wordMap.ContainsKey(word))
        {
            wordMap[word] = new List<string>();
        }

        wordMap[word].Add(nextWord);
    }

    public static string GenerateSentence(int length)
    {
        string currentWord = wordMap.Keys.ToArray()[random.Next(wordMap.Count)];
        string sentence = currentWord;

        for (int i = 1; i < length; i++)
        {
            string nextWord = wordMap[currentWord][random.Next(wordMap[currentWord].Count)];
            sentence += " " + nextWord;
            currentWord = nextWord;
        }

        return sentence;
    }

    static void Main()
    {
        AddWord("I", "like");
        AddWord("like", "to");
        AddWord("to", "code");
        AddWord("code", "in");
        AddWord("in", "C#");
        AddWord("C#", "programming");

        string randomSentence = GenerateSentence(6);
        Console.WriteLine(randomSentence);
    }
}
