
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string input = "hello world hello world hello";
        Dictionary<string, int> wordCount = new Dictionary<string, int>();

        string[] words = input.Split(' ');

        foreach (string word in words)
        {
            if (wordCount.ContainsKey(word))
            {
                wordCount[word]++;
            }
            else
            {
                wordCount[word] = 1;
            }
        }

        Console.WriteLine("Word\t\tCount");
        foreach (var item in wordCount)
        {
            Console.WriteLine($"{item.Key}\t\t{item.Value}");
        }
    }
}
