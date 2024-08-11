
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
                charCount.Add(c, 1);
            }
        }

        foreach (var pair in charCount)
        {
            Console.WriteLine($"Character '{pair.Key}' occurs {pair.Value} time(s)");
        }
    }
}
