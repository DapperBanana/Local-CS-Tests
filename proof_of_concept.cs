
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string input = "programming";
        
        bool isIsogram = IsIsogram(input);
        
        if(isIsogram)
        {
            Console.WriteLine("The given string is an isogram.");
        }
        else
        {
            Console.WriteLine("The given string is not an isogram.");
        }
    }
    
    static bool IsIsogram(string input)
    {
        HashSet<char> charSet = new HashSet<char>();
        
        foreach(char ch in input)
        {
            // Check if the character is already present in the HashSet
            if(charSet.Contains(ch))
            {
                return false;
            }
            
            // Add the character to the HashSet
            charSet.Add(ch);
        }
        
        return true;
    }
}
