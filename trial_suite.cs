
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string inputString = "Hello, World!";
        Dictionary<char, int> charCount = new Dictionary<char, int>();

        foreach (char c in inputString)
        {
            if (charCount.ContainsKey(c))
            {
                charCount[c]++;
            }
            else
            {
                charCount.Add(c, 1);
            }
        }

        Console.WriteLine("Character Counts:");
        foreach (var kvp in charCount)
        {
            Console.WriteLine($"{kvp.Key}: {kvp.Value}");
        }
    }
}
