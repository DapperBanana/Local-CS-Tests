
using System;

class AnagramChecker
{
    static bool IsAnagram(string str1, string str2)
    {
        if (str1.Length != str2.Length)
        {
            return false;
        }

        char[] str1Arr = str1.ToCharArray();
        char[] str2Arr = str2.ToCharArray();

        Array.Sort(str1Arr);
        Array.Sort(str2Arr);

        for (int i = 0; i < str1Arr.Length; i++)
        {
            if (str1Arr[i] != str2Arr[i])
            {
                return false;
            }
        }

        return true;
    }

    static void Main()
    {
        Console.WriteLine("Enter the first string: ");
        string str1 = Console.ReadLine();

        Console.WriteLine("Enter the second string: ");
        string str2 = Console.ReadLine();

        if (IsAnagram(str1, str2))
        {
            Console.WriteLine("The two strings are anagrams.");
        }
        else
        {
            Console.WriteLine("The two strings are not anagrams.");
        }
    }
}
