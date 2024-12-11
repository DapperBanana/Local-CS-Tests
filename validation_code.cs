
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string input = "hello world";
        
        Dictionary<char, int> charCounts = new Dictionary<char, int>();

        foreach (char c in input)
        {
            if (charCounts.ContainsKey(c))
            {
                charCounts[c]++;
            }
            else
            {
                charCounts[c] = 1;
            }
        }

        foreach (var entry in charCounts)
        {
            Console.WriteLine($"Character '{entry.Key}' occurs {entry.Value} times.");
        }
    }
}
