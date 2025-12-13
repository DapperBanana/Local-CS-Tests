using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        string str1 = "hello world";
        string str2 = "world peace";

        // Find common characters, considering duplicates
        var commonChars = GetCommonCharacters(str1, str2);

        Console.WriteLine("Common characters: " + new string(commonChars.ToArray()));
    }

    static List<char> GetCommonCharacters(string s1, string s2)
    {
        var list1 = s1.ToList();
        var list2 = s2.ToList();
        var commonChars = new List<char>();

        foreach (var ch in list1)
        {
            if (list2.Contains(ch))
            {
                commonChars.Add(ch);
                list2.Remove(ch); // Remove to handle duplicate characters correctly
            }
        }

        return commonChars;
    }
}