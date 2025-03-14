
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        Dictionary<char, int> charCount = new Dictionary<char, int>();

        foreach (char c in input)
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

        Console.WriteLine("Character counts:");
        foreach (var pair in charCount)
        {
            Console.WriteLine($"'{pair.Key}': {pair.Value}");
        }
    }
}
