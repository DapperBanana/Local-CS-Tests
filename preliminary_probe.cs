using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

class MarkovChainGenerator
{
    private Dictionary<string, List<string>> markovChain = new Dictionary<string, List<string>>();
    private Random random = new Random();

    // Loads text from a file and builds the Markov chain
    public void LoadText(string filename)
    {
        string text = File.ReadAllText(filename);
        string[] words = text.Split(new char[] { ' ', '\n', '\r', '.', ',', ';', ':', '!', '?', '-', '\"', '\'' }, StringSplitOptions.RemoveEmptyEntries);

        for (int i = 0; i < words.Length - 1; i++)
        {
            string key = words[i].ToLower();
            string nextWord = words[i + 1].ToLower();

            if (!markovChain.ContainsKey(key))
            {
                markovChain[key] = new List<string>();
            }
            markovChain[key].Add(nextWord);
        }
    }

    // Generates a random sentence with a specified max length
    public string GenerateSentence(int maxWords = 15)
    {
        if (markovChain.Count == 0)
        {
            return string.Empty;
        }

        // Pick a random starting word that starts with a capital letter (optional)
        var keys = new List<string>(markovChain.Keys);
        string currentWord = keys[random.Next(keys.Count)];

        StringBuilder sentence = new StringBuilder();
        sentence.Append(Capitalize(currentWord));

        for (int i = 1; i < maxWords; i++)
        {
            List<string> nextWords;
            if (markovChain.TryGetValue(currentWord.ToLower(), out nextWords))
            {
                currentWord = nextWords[random.Next(nextWords.Count)];
                // Capitalize the first word
                if (i == 1)
                {
                    sentence.Append(" " + Capitalize(currentWord));
                }
                else
                {
                    sentence.Append(" " + currentWord);
                }
            }
            else
            {
                break;
            }

            // End the sentence if the next word is punctuation (optional)
            if (currentWord.EndsWith(".") || currentWord.EndsWith("!") || currentWord.EndsWith("?"))
            {
                break;
            }
        }

        sentence.Append(".");
        return sentence.ToString();
    }

    private string Capitalize(string word)
    {
        if (string.IsNullOrEmpty(word))
            return word;
        return char.ToUpper(word[0]) + word.Substring(1);
    }
}

class Program
{
    static void Main(string[] args)
    {
        var generator = new MarkovChainGenerator();

        // Path to your text file
        string filename = "sample.txt";

        // Ensure the file exists
        if (!File.Exists(filename))
        {
            Console.WriteLine($"File {filename} not found.");
            return;
        }

        generator.LoadText(filename);

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(generator.GenerateSentence());
        }
    }
}