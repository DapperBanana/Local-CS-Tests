
using System;

class Program
{
    static void Main()
    {
        string input;

        Console.Write("Enter text to translate: ");
        input = Console.ReadLine();

        string translatedText = TranslateText(input);

        Console.WriteLine("Translated text: " + translatedText);
    }

    static string TranslateText(string text)
    {
        string translatedText = "";

        foreach (char c in text)
        {
            if (c == 'a')
            {
                translatedText += 'z';
            }
            else if (c == 'b')
            {
                translatedText += 'y';
            }
            else if (c == 'c')
            {
                translatedText += 'x';
            }
            // Add more translations for other letters here

            else
            {
                translatedText += c;
            }
        }

        return translatedText;
    }
}
