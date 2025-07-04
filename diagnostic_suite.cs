
using System;

class Program
{
    static void Main()
    {
        string sentence = "The quick brown fox jumps over the lazy dog";
        
        string[] words = sentence.Split(' ');

        int maxLength = 0;
        foreach(string word in words)
        {
            if(word.Length > maxLength)
            {
                maxLength = word.Length;
            }
        }

        Console.WriteLine($"The length of the longest word in the sentence is: {maxLength}");
    }
}
