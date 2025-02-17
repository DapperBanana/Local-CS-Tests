
using System;
using System.Collections.Generic;

class Program
{
    static bool IsIsogram(string str)
    {
        HashSet<char> seen = new HashSet<char>();
        
        foreach(char c in str)
        {
            if(char.IsLetter(c))
            {
                char lowerC = char.ToLower(c);
                if(seen.Contains(lowerC))
                {
                    return false;
                }
                seen.Add(lowerC);
            }
        }
        
        return true;
    }

    static void Main()
    {
        string input = "hello";
        bool isIsogram = IsIsogram(input);

        if (isIsogram)
        {
            Console.WriteLine($"{input} is an isogram.");
        }
        else
        {
            Console.WriteLine($"{input} is not an isogram.");
        }
    }
}
