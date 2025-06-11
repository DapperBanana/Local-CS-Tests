
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
            if (charCount.ContainsKey(c))
            {
                charCount[c]++;
            }
            else
            {
                charCount[c] = 1;
            }
        }

        foreach (KeyValuePair<char, int> entry in charCount)
        {
            Console.WriteLine($"Character '{entry.Key}' occurs {entry.Value} times");
        }
    }
}
