
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a sentence: ");
        string sentence = Console.ReadLine();

        string[] words = sentence.Split(' ');
        Array.Reverse(words);

        string reversedSentence = string.Join(" ", words);

        Console.WriteLine("Reversed sentence: " + reversedSentence);
    }
}
