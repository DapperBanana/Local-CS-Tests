
using System;
using System.Linq;

class AnagramChecker
{
    static void Main()
    {
        Console.Write("Enter the first string: ");
        string str1 = Console.ReadLine().ToLower();

        Console.Write("Enter the second string: ");
        string str2 = Console.ReadLine().ToLower();

        bool isAnagram = CheckAnagram(str1, str2);

        if (isAnagram)
        {
            Console.WriteLine("The strings are anagrams.");
        }
        else
        {
            Console.WriteLine("The strings are not anagrams.");
        }
    }

    static bool CheckAnagram(string str1, string str2)
    {
        if (str1.Length != str2.Length)
        {
            return false;
        }

        var charArray1 = str1.ToCharArray();
        Array.Sort(charArray1);

        var charArray2 = str2.ToCharArray();
        Array.Sort(charArray2);

        return charArray1.SequenceEqual(charArray2);
    }
}
