
using System;

namespace LanguageTranslator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Language Translator!");

            Console.Write("Enter the text you would like to translate: ");
            string inputText = Console.ReadLine();

            Console.WriteLine("\nSelect a language to translate to:");
            Console.WriteLine("1. Spanish");
            Console.WriteLine("2. French");
            Console.WriteLine("3. German");
            Console.Write("Enter your choice (1, 2, or 3): ");
            int choice = Convert.ToInt32(Console.ReadLine());

            string translatedText = TranslateText(inputText, choice);

            Console.WriteLine("\nTranslated text:");
            Console.WriteLine(translatedText);
        }

        static string TranslateText(string text, int choice)
        {
            switch (choice)
            {
                case 1:
                    return TranslateToSpanish(text);
                case 2:
                    return TranslateToFrench(text);
                case 3:
                    return TranslateToGerman(text);
                default:
                    return "Invalid choice";
            }
        }

        static string TranslateToSpanish(string text)
        {
            // Dummy translation for demonstration purposes
            return "Translated to Spanish: " + text;
        }

        static string TranslateToFrench(string text)
        {
            // Dummy translation for demonstration purposes
            return "Translated to French: " + text;
        }

        static string TranslateToGerman(string text)
        {
            // Dummy translation for demonstration purposes
            return "Translated to German: " + text;
        }
    }
}
