
using System;

class AnagramChecker
{
    public static bool CheckAnagram(string str1, string str2)
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
        string inputStr1 = "listen";
        string inputStr2 = "silent";

        if (CheckAnagram(inputStr1, inputStr2))
        {
            Console.WriteLine($"{inputStr1} is an anagram of {inputStr2}.");
        }
        else
        {
            Console.WriteLine($"{inputStr1} is not an anagram of {inputStr2}.");
        }
    }
}
