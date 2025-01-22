
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string str1 = "hello";
        string str2 = "world";

        List<char> commonChars = FindCommonCharacters(str1, str2);
        
        Console.WriteLine("Common characters between the two strings are:");
        foreach (char ch in commonChars)
        {
            Console.Write(ch + " ");
        }
    }

    static List<char> FindCommonCharacters(string str1, string str2)
    {
        List<char> commonChars = new List<char>();
        HashSet<char> set1 = new HashSet<char>(str1);
        HashSet<char> set2 = new HashSet<char>(str2);

        foreach (char ch in set1)
        {
            if (set2.Contains(ch))
            {
                commonChars.Add(ch);
            }
        }

        return commonChars;
    }
}
