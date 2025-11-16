
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string input = "hello world";
        
        Dictionary<char, int> charCount = new Dictionary<char, int>();

        foreach (char c in input)
        {
            if (!charCount.ContainsKey(c))
            {
                charCount[c] = 1;
            }
            else
            {
                charCount[c]++;
            }
        }

        foreach (var pair in charCount)
        {
            Console.WriteLine($"{pair.Key}: {pair.Value}");
        }
    }
}
