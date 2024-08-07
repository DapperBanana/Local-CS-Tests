
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a sentence:");
        string input = Console.ReadLine();

        string reversedSentence = ReverseWordsInSentence(input);

        Console.WriteLine("Reversed sentence: " + reversedSentence);
    }

    static string ReverseWordsInSentence(string sentence)
    {
        string[] words = sentence.Split(' ');
        Array.Reverse(words);
        return string.Join(" ", words);
    }
}
