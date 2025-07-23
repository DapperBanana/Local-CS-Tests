
using System;
using System.Linq;

class AnagramChecker
{
    static void Main()
    {
        Console.WriteLine("Enter the first string:");
        string str1 = Console.ReadLine().ToLower();

        Console.WriteLine("Enter the second string:");
        string str2 = Console.ReadLine().ToLower();

        if (IsAnagram(str1, str2))
        {
            Console.WriteLine("The strings are anagrams.");
        }
        else
        {
            Console.WriteLine("The strings are not anagrams.");
        }
    }

    static bool IsAnagram(string str1, string str2)
    {
        if (str1.Length != str2.Length)
        {
            return false;
        }

        char[] charArray1 = str1.ToCharArray();
        char[] charArray2 = str2.ToCharArray();

        Array.Sort(charArray1);
        Array.Sort(charArray2);

        string sortedStr1 = new string(charArray1);
        string sortedStr2 = new string(charArray2);

        return sortedStr1 == sortedStr2;
    }
}
