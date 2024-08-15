
using System;
using System.Collections.Generic;

class Program
{
    static bool IsIsogram(string str)
    {
        HashSet<char> charSet = new HashSet<char>();
        
        foreach(char c in str)
        {
            if (charSet.Contains(c))
            {
                return false;
            }
            else
            {
                charSet.Add(c);
            }
        }
        
        return true;
    }
    
    static void Main()
    {
        string input = "programming";
        
        if (IsIsogram(input))
        {
            Console.WriteLine("The input string is an isogram.");
        }
        else
        {
            Console.WriteLine("The input string is not an isogram.");
        }
    }
}
