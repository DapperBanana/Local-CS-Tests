
using System;

class AnagramChecker
{
    public static bool IsAnagram(string firstString, string secondString)
    {
        if (firstString.Length != secondString.Length)
        {
            return false;
        }

        char[] firstArr = firstString.ToCharArray();
        char[] secondArr = secondString.ToCharArray();

        Array.Sort(firstArr);
        Array.Sort(secondArr);

        for (int i = 0; i < firstArr.Length; i++)
        {
            if (firstArr[i] != secondArr[i])
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
            Console.WriteLine($"{str1} is an anagram of {str2}.");
        }
        else
        {
            Console.WriteLine($"{str1} is not an anagram of {str2}.");
        }
    }
}
