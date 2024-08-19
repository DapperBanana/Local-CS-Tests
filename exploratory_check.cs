
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string str1 = "hello";
        string str2 = "world";

        List<char> commonChars = FindCommonCharacters(str1, str2);

        Console.WriteLine("Common characters between \"" + str1 + "\" and \"" + str2 + "\": ");

        foreach (char c in commonChars)
        {
            Console.Write(c + " ");
        }

        Console.ReadLine();
    }

    static List<char> FindCommonCharacters(string str1, string str2)
    {
        List<char> commonChars = new List<char>();

        foreach (char c in str1)
        {
            if (str2.Contains(c) && !commonChars.Contains(c))
            {
                commonChars.Add(c);
            }
        }

        return commonChars;
    }
}
