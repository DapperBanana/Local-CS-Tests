
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string input = "Hello World";
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

        Console.WriteLine("Character Counts:");
        foreach (var entry in charCounts)
        {
            Console.WriteLine($"'{entry.Key}': {entry.Value}");
        }
    }
}
