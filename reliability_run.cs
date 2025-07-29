
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string str1 = "hello";
        string str2 = "world";

        List<char> commonChars = FindCommonCharacters(str1, str2);

        Console.WriteLine("Common characters between '{0}' and '{1}':", str1, str2);
        foreach (char c in commonChars)
        {
            Console.Write(c + " ");
        }
    }

    static List<char> FindCommonCharacters(string str1, string str2)
    {
        List<char> commonChars = new List<char>();

        foreach (char c1 in str1)
        {
            if (str2.Contains(c1) && !commonChars.Contains(c1))
            {
                commonChars.Add(c1);
            }
        }

        return commonChars;
    }
}
