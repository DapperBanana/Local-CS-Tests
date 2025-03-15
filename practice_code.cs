
using System;

class AnagramChecker
{
    static bool CheckIfAnagram(string str1, string str2)
    {
        if (str1.Length != str2.Length)
        {
            return false;
        }

        char[] charArray1 = str1.ToLower().ToCharArray();
        char[] charArray2 = str2.ToLower().ToCharArray();

        Array.Sort(charArray1);
        Array.Sort(charArray2);

        string sortedStr1 = new string(charArray1);
        string sortedStr2 = new string(charArray2);

        return sortedStr1 == sortedStr2;
    }

    static void Main()
    {
        string str1 = "listen";
        string str2 = "silent";

        if (CheckIfAnagram(str1, str2))
        {
            Console.WriteLine($"{str1} and {str2} are anagrams.");
        }
        else
        {
            Console.WriteLine($"{str1} and {str2} are not anagrams.");
        }
    }
}
