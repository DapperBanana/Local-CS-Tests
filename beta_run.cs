
using System;
using System.Collections.Generic;

class Program
{
    static bool IsIsogram(string str)
    {
        HashSet<char> set = new HashSet<char>();

        foreach(char c in str)
        {
            if (set.Contains(char.ToLower(c)))
            {
                return false;
            }
            else
            {
                set.Add(char.ToLower(c));
            }
        }

        return true;
    }

    static void Main()
    {
        string input = "hello";
        bool result = IsIsogram(input);

        if (result)
        {
            Console.WriteLine("The string '" + input + "' is an isogram.");
        }
        else
        {
            Console.WriteLine("The string '" + input + "' is not an isogram.");
        }

        input = "programming";
        result = IsIsogram(input);

        if (result)
        {
            Console.WriteLine("The string '" + input + "' is an isogram.");
        }
        else
        {
            Console.WriteLine("The string '" + input + "' is not an isogram.");
        }
    }
}
