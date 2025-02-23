
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();
        
        Dictionary<char, int> charCount = new Dictionary<char, int>();
        
        foreach(char c in input)
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
        
        foreach(var kvp in charCount)
        {
            Console.WriteLine("Character: {0}, Count: {1}", kvp.Key, kvp.Value);
        }
    }
}
