
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string inputString = "hello world";
        
        Dictionary<char, int> characterCount = new Dictionary<char, int>();

        // Count the number of occurrences of each character in the input string
        foreach (char c in inputString)
        {
            if (characterCount.ContainsKey(c))
            {
                characterCount[c]++;
            }
            else
            {
                characterCount[c] = 1;
            }
        }

        // Display the results
        foreach (var pair in characterCount)
        {
            Console.WriteLine($"'{pair.Key}': {pair.Value}");
        }
    }
}
