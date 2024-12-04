
using System;
using System.Collections.Generic;

class Program
{
    static bool IsIsogram(string str)
    {
        var charSet = new HashSet<char>();

        foreach (char c in str.ToLower())
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
        string str = "hello";
        bool isIsogram = IsIsogram(str);

        if (isIsogram)
        {
            Console.WriteLine($"The string '{str}' is an isogram.");
        }
        else
        {
            Console.WriteLine($"The string '{str}' is not an isogram.");
        }
    }
}
