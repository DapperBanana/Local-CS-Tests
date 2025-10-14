
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a sentence:");
        string sentence = Console.ReadLine();

        string reversedSentence = ReverseWordsInSentence(sentence);
        
        Console.WriteLine($"Reversed sentence: {reversedSentence}");
    }

    static string ReverseWordsInSentence(string sentence)
    {
        string[] words = sentence.Split(' ');

        Array.Reverse(words);

        return string.Join(' ', words);
    }
}
