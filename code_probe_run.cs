
using System;
using System.Collections.Generic;

class Program
{
    static bool IsIsogram(string str)
    {
        HashSet<char> set = new HashSet<char>();

        foreach (char ch in str)
        {
            if (char.IsLetter(ch))
            {
                char lowerCh = char.ToLower(ch);
                if (set.Contains(lowerCh))
                {
                    return false;
                }
                
                set.Add(lowerCh);
            }
        }
        
        return true;
    }

    static void Main()
    {
        string input = "hello";
        
        if (IsIsogram(input))
        {
            Console.WriteLine("The string is an isogram.");
        }
        else
        {
            Console.WriteLine("The string is not an isogram.");
        }
    }
}
