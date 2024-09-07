
using System;
using System.Collections.Generic;

class Program
{
    static Dictionary<string, string> englishToFrenchDictionary = new Dictionary<string, string>
    {
        {"hello", "bonjour"},
        {"goodbye", "au revoir"},
        // Add more translations as needed
    };

    static Dictionary<string, string> frenchToEnglishDictionary = new Dictionary<string, string>();

    static void Main()
    {
        // Populate French to English Dictionary
        foreach (var pair in englishToFrenchDictionary)
        {
            frenchToEnglishDictionary.Add(pair.Value, pair.Key);
        }

        Console.WriteLine("Enter text to translate:");
        string input = Console.ReadLine();

        Console.WriteLine("Translate from English to French (1) or French to English (2):");
        int choice = int.Parse(Console.ReadLine());

        if (choice == 1)
        {
            TranslateEnglishToFrench(input);
        }
        else if (choice == 2)
        {
            TranslateFrenchToEnglish(input);
        }
        else
        {
            Console.WriteLine("Invalid choice. Please enter 1 for English to French or 2 for French to English.");
        }
    }

    static void TranslateEnglishToFrench(string input)
    {
        string[] words = input.Split(' ');
        List<string> translatedWords = new List<string>();

        foreach (string word in words)
        {
            if (englishToFrenchDictionary.ContainsKey(word.ToLower()))
            {
                translatedWords.Add(englishToFrenchDictionary[word.ToLower()]);
            }
            else
            {
                translatedWords.Add(word);
            }
        }

        Console.WriteLine("Translated text: " + string.Join(" ", translatedWords));
    }

    static void TranslateFrenchToEnglish(string input)
    {
        string[] words = input.Split(' ');
        List<string> translatedWords = new List<string>();

        foreach (string word in words)
        {
            if (frenchToEnglishDictionary.ContainsKey(word.ToLower()))
            {
                translatedWords.Add(frenchToEnglishDictionary[word.ToLower()]);
            }
            else
            {
                translatedWords.Add(word);
            }
        }

        Console.WriteLine("Translated text: " + string.Join(" ", translatedWords));
    }
}
