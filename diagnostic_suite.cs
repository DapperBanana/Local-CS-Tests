
using System;

class Program
{
    static bool IsAnagram(string str1, string str2)
    {
        // Check if the lengths of the two strings are not equal
        if (str1.Length != str2.Length)
        {
            return false;
        }

        // Sort the characters of both strings
        char[] arr1 = str1.ToCharArray();
        char[] arr2 = str2.ToCharArray();
        Array.Sort(arr1);
        Array.Sort(arr2);

        // Compare the sorted strings
        for (int i = 0; i < str1.Length; i++)
        {
            if (arr1[i] != arr2[i])
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
