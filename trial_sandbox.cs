
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string input = "hello";
        
        bool isIsogram = CheckIsogram(input);
        
        if(isIsogram)
        {
            Console.WriteLine("The string is an isogram.");
        }
        else
        {
            Console.WriteLine("The string is not an isogram.");
        }
    }
    
    static bool CheckIsogram(string input)
    {
        HashSet<char> chars = new HashSet<char>();
        
        foreach(char c in input)
        {
            if(chars.Contains(c))
            {
                return false;
            }
            chars.Add(c);
        }
        
        return true;
    }
}
