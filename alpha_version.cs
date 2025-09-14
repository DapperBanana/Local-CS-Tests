
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string inputString = "hello world";
        
        Dictionary<char, int> charCount = new Dictionary<char, int>();

        foreach (char c in inputString)
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

        foreach (var item in charCount)
        {
            Console.WriteLine("Character '{0}' occurs {1} time(s)", item.Key, item.Value);
        }
    }
}
