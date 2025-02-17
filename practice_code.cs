
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string inputString = "Hello World";
        
        Dictionary<char, int> charCounts = new Dictionary<char, int>();

        foreach (char c in inputString)
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
        foreach (var pair in charCounts)
        {
            Console.WriteLine($"{pair.Key}: {pair.Value}");
        }
    }
}
