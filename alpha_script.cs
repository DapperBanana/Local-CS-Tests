
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Basic Language Translator!");
        
        Console.WriteLine("Please enter a sentence in English to translate:");
        string input = Console.ReadLine();
        
        string translatedSentence = TranslateSentence(input);
        
        Console.WriteLine("Translated sentence: " + translatedSentence);
    }

    static string TranslateSentence(string sentence)
    {
        string translatedSentence = "";
        
        // Basic language translation rules
        foreach(char c in sentence)
        {
            if(Char.IsLetter(c))
            {
                if(Char.IsUpper(c))
                {
                    translatedSentence += Char.ToUpper((char)(c + 1));
                }
                else
                {
                    translatedSentence += (char)(c + 1);
                }
            }
            else
            {
                translatedSentence += c;
            }
        }
        
        return translatedSentence;
    }
}
