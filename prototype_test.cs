
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a sentence:");
        string sentence = Console.ReadLine();

        string reversedSentence = ReverseWords(sentence);
        Console.WriteLine("Reversed sentence: " + reversedSentence);
    }

    static string ReverseWords(string sentence)
    {
        string[] words = sentence.Split(' ');
        Array.Reverse(words);
        return string.Join(" ", words);
    }
}
