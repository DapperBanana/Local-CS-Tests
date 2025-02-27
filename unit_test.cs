
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a sentence: ");
        string sentence = Console.ReadLine();
        
        string[] words = sentence.Split(' ');
        Array.Reverse(words);
        string reversedSentence = string.Join(" ", words);
        
        Console.WriteLine("Reversed sentence: ");
        Console.WriteLine(reversedSentence);
    }
}
