
using System;

class AnagramChecker
{
    static bool CheckIfAnagram(string str1, string str2)
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

        return sortedStr1.Equals(sortedStr2);
    }

    static void Main()
    {
        string input1 = "listen";
        string input2 = "silent";

        if (CheckIfAnagram(input1, input2))
        {
            Console.WriteLine("The strings are anagrams.");
        }
        else
        {
            Console.WriteLine("The strings are not anagrams.");
        }
    }
}
