
using System;

class Program
{
    static void Main()
    {
        string sentence = "Hello world, how are you?";
        string reversedSentence = ReverseSentence(sentence);

        Console.WriteLine(reversedSentence);
    }

    static string ReverseSentence(string sentence)
    {
        string[] words = sentence.Split(' ');
        Array.Reverse(words);
        return string.Join(" ", words);
    }
}
