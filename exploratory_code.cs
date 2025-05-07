
using System;

class AnagramChecker
{
    static bool IsAnagram(string str1, string str2)
    {
        // Check if the length of both strings is equal
        if (str1.Length != str2.Length)
        {
            return false;
        }

        // Convert strings to character arrays
        char[] arr1 = str1.ToLower().ToCharArray();
        char[] arr2 = str2.ToLower().ToCharArray();

        // Sort the character arrays
        Array.Sort(arr1);
        Array.Sort(arr2);

        // Check if the sorted arrays are equal
        for (int i = 0; i < arr1.Length; i++)
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
