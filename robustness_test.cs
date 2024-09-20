
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string str1 = "hello";
        string str2 = "world";

        HashSet<char> commonChars = FindCommonCharacters(str1, str2);

        Console.WriteLine("Common characters between '{0}' and '{1}':", str1, str2);
        foreach (char c in commonChars)
        {
            Console.Write(c + " ");
        }
    }

    static HashSet<char> FindCommonCharacters(string str1, string str2)
    {
        HashSet<char> set1 = new HashSet<char>(str1);
        HashSet<char> commonChars = new HashSet<char>();

        foreach (char c in str2)
        {
            if (set1.Contains(c))
            {
                commonChars.Add(c);
            }
        }

        return commonChars;
    }
}
