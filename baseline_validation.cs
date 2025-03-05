
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string input = "hello";
        
        if (IsIsogram(input))
        {
            Console.WriteLine($"{input} is an isogram.");
        }
        else
        {
            Console.WriteLine($"{input} is not an isogram.");
        }
    }

    static bool IsIsogram(string input)
    {
        // Create a dictionary to store the occurrences of each character
        Dictionary<char, int> occurrences = new Dictionary<char, int>();

        foreach (char c in input.ToLower())
        {
            if (Char.IsLetter(c))
            {
                if (occurrences.ContainsKey(c))
                {
                    return false; // If duplicate character is found, return false
                }
                else
                {
                    occurrences.Add(c, 1);
                }
            }
        }

        return true; // No duplicate characters found, return true
    }
}
