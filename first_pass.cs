
using System;
using System.Collections.Generic;

class Program
{
    static bool IsIsogram(string str)
    {
        HashSet<char> set = new HashSet<char>();

        foreach (char c in str)
        {
            if (char.IsLetter(c))
            {
                if (!set.Add(char.ToLower(c)))
                {
                    return false;
                }
            }
        }

        return true;
    }

    static void Main()
    {
        string input = "hello";
        
        if (IsIsogram(input))
        {
            Console.WriteLine("The given string \"" + input + "\" is an isogram.");
        }
        else
        {
            Console.WriteLine("The given string \"" + input + "\" is not an isogram.");
        }
    }
}
