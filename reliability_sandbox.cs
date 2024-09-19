
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

        foreach (KeyValuePair<char, int> kvp in charCount)
        {
            Console.WriteLine("Character '{0}' occurs {1} times", kvp.Key, kvp.Value);
        }
    }
}
