
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.Write("Enter the first string: ");
        string str1 = Console.ReadLine();

        Console.Write("Enter the second string: ");
        string str2 = Console.ReadLine();

        List<char> commonChars = FindCommonCharacters(str1, str2);

        Console.WriteLine("Common characters between the two strings:");
        foreach (char ch in commonChars)
        {
            Console.Write(ch + " ");
        }
    }

    static List<char> FindCommonCharacters(string str1, string str2)
    {
        List<char> commonChars = new List<char>();

        foreach (char ch in str1)
        {
            if (str2.Contains(ch) && !commonChars.Contains(ch))
            {
                commonChars.Add(ch);
            }
        }

        return commonChars;
    }
}
