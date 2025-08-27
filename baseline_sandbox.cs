
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
        HashSet<char> characters = new HashSet<char>();

        foreach (char c in str)
        {
            if (char.IsLetter(c))
            {
                if (!characters.Add(char.ToLower(c)))
                {
                    return false;
                }
            }
        }

        return true;
    }
}
