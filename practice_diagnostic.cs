
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
        foreach (char ch in commonChars)
        {
            Console.Write(ch + " ");
        }
    }

    static List<char> FindCommonCharacters(string str1, string str2)
    {
        List<char> commonChars = new List<char>();

        foreach (char ch1 in str1)
        {
            if (str2.Contains(ch1) && !commonChars.Contains(ch1))
            {
                commonChars.Add(ch1);
            }
        }

        return commonChars;
    }
}
