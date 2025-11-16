
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string input = "Hello";
        
        bool isIsogram = CheckIsIsogram(input);
        
        if (isIsogram)
        {
            Console.WriteLine($"{input} is an isogram.");
        }
        else
        {
            Console.WriteLine($"{input} is not an isogram.");
        }
    }
    
    static bool CheckIsIsogram(string str)
    {
        HashSet<char> set = new HashSet<char>();
        
        foreach (char c in str)
        {
            if (Char.IsLetter(c))
            {
                if (!set.Add(Char.ToLower(c)))
                {
                    return false;
                }
            }
        }
        
        return true;
    }
}
