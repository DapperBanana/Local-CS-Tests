
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
    
    static bool IsIsogram(string str)
    {
        HashSet<char> seen = new HashSet<char>();
        foreach (char c in str)
        {
            if (seen.Contains(char.ToLower(c)))
            {
                return false;
            }
            else
            {
                seen.Add(char.ToLower(c));
            }
        }
        
        return true;
    }
}
