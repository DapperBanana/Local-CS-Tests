
using System;

class AnagramChecker
{
    static bool IsAnagram(string str1, string str2)
    {
        if (str1.Length != str2.Length)
        {
            return false;
        }

        str1 = SortString(str1);
        str2 = SortString(str2);

        return str1 == str2;
    }

    static string SortString(string str)
    {
        char[] charArray = str.ToCharArray();
        Array.Sort(charArray);
        return new string(charArray);
    }

    static void Main()
    {
        Console.Write("Enter the first string: ");
        string str1 = Console.ReadLine();

        Console.Write("Enter the second string: ");
        string str2 = Console.ReadLine();

        if (IsAnagram(str1, str2))
        {
            Console.WriteLine("The strings are anagrams.");
        }
        else
        {
            Console.WriteLine("The strings are not anagrams.");
        }
    }
}
