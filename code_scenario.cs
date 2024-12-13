
using System;

class AnagramChecker
{
    static void Main()
    {
        Console.Write("Enter first string: ");
        string str1 = Console.ReadLine();

        Console.Write("Enter second string: ");
        string str2 = Console.ReadLine();

        bool isAnagram = CheckIfAnagram(str1, str2);

        if (isAnagram)
        {
            Console.WriteLine("The two strings are anagrams.");
        }
        else
        {
            Console.WriteLine("The two strings are not anagrams.");
        }
    }

    static bool CheckIfAnagram(string str1, string str2)
    {
        if (str1.Length != str2.Length)
        {
            return false;
        }

        int[] charCount = new int[256];

        foreach (char c in str1)
        {
            charCount[c]++;
        }

        foreach (char c in str2)
        {
            charCount[c]--;
        }

        for (int i = 0; i < 256; i++)
        {
            if (charCount[i] != 0)
            {
                return false;
            }
        }

        return true;
    }
}
