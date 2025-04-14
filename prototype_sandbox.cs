
using System;

class AnagramChecker
{
    public static bool IsAnagram(string str1, string str2)
    {
        if (str1.Length != str2.Length)
        {
            return false;
        }

        char[] charArray1 = str1.ToLower().ToCharArray();
        char[] charArray2 = str2.ToLower().ToCharArray();

        Array.Sort(charArray1);
        Array.Sort(charArray2);

        return new string(charArray1) == new string(charArray2);
    }

    static void Main()
    {
        string str1 = "listen";
        string str2 = "silent";

        if (IsAnagram(str1, str2))
        {
            Console.WriteLine($"{str1} is an anagram of {str2}");
        }
        else
        {
            Console.WriteLine($"{str1} is not an anagram of {str2}");
        }
    }
}
