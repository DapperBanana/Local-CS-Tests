
using System;
using System.Collections.Generic;

class LanguageTranslator
{
    private Dictionary<string, string> translations;

    public LanguageTranslator()
    {
        translations = new Dictionary<string, string>
        {
            { "hello", "hallo" },
            { "goodbye", "auf wiedersehen" },
            { "thank you", "danke" }
        };
    }

    public string Translate(string text)
    {
        if (translations.ContainsKey(text))
        {
            return translations[text];
        }
        else
        {
            return "Translation not found";
        }
    }

    static void Main()
    {
        LanguageTranslator translator = new LanguageTranslator();

        Console.WriteLine("Enter text to translate:");
        string text = Console.ReadLine();

        string translation = translator.Translate(text.ToLower());
        Console.WriteLine($"Translation: {translation}");
    }
}
