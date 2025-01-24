
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, string> translationDictionary = new Dictionary<string, string>
        {
            { "hello", "hola" },
            { "goodbye", "adios" },
            { "thank you", "gracias" },
            { "please", "por favor" }
        };

        Console.WriteLine("Enter the text you want to translate:");
        string input = Console.ReadLine();

        string[] words = input.Split(' ');
        string translatedText = "";

        foreach (string word in words)
        {
            if (translationDictionary.ContainsKey(word.ToLower()))
            {
                translatedText += translationDictionary[word.ToLower()] + " ";
            }
            else
            {
                translatedText += word + " ";
            }
        }

        Console.WriteLine("Translated text: " + translatedText);
    }
}
