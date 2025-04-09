
using System;

class AnagramChecker
{
    static bool IsAnagram(string str1, string str2)
    {
        if (str1.Length != str2.Length)
        {
            return false;
        }

        char[] charArray1 = str1.ToCharArray();
        Array.Sort(charArray1);

        char[] charArray2 = str2.ToCharArray();
        Array.Sort(charArray2);

        for (int i = 0; i < str1.Length; i++)
        {
            if (charArray1[i] != charArray2[i])
            {
                return false;
            }
        }

        return true;
    }

    static void Main()
    {
        string str1 = "listen";
        string str2 = "silent";

        if (IsAnagram(str1, str2))
        {
            Console.WriteLine($"{str1} and {str2} are anagrams.");
        }
        else
        {
            Console.WriteLine($"{str1} and {str2} are not anagrams.");
        }
    }
}
