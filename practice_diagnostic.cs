
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a string:");
        string input = Console.ReadLine();
        
        if (IsIsogram(input))
        {
            Console.WriteLine("The input string is an isogram.");
        }
        else
        {
            Console.WriteLine("The input string is not an isogram.");
        }
    }
    
    static bool IsIsogram(string input)
    {
        HashSet<char> seenChars = new HashSet<char>();
        
        foreach (char c in input)
        {
            if (char.IsLetter(c))
            {
                char lowerC = char.ToLower(c);
                if (seenChars.Contains(lowerC))
                {
                    return false;
                }
                seenChars.Add(lowerC);
            }
        }
        
        return true;
    }
}
