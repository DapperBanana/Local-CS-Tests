
using System;

class AnagramChecker
{
    static bool IsAnagram(string str1, string str2)
    {
        // Check if the lengths of the two strings are not equal
        if (str1.Length != str2.Length)
        {
            return false;
        }

        // Convert the strings to char arrays and sort them
        char[] charArray1 = str1.ToCharArray();
        char[] charArray2 = str2.ToCharArray();
        Array.Sort(charArray1);
        Array.Sort(charArray2);

        // Compare the sorted char arrays
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
        string input1 = "listen";
        string input2 = "silent";

        if (IsAnagram(input1, input2))
        {
            Console.WriteLine("The strings are anagrams.");
        }
        else
        {
            Console.WriteLine("The strings are not anagrams.");
        }
    }
}
