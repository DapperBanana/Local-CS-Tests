
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string input = "hello";
        
        if(IsIsogram(input))
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
        HashSet<char> charSet = new HashSet<char>();

        foreach(char c in input)
        {
            if(charSet.Contains(char.ToLower(c)))
            {
                return false;
            }

            charSet.Add(char.ToLower(c));
        }

        return true;
    }
}
