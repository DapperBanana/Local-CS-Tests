using System;

class AnagramChecker
{
    public static bool AreAnagrams(string str1, string str2)
    {
        if (str1 == null || str2 == null || str1.Length != str2.Length)
            return false;

        char[] arr1 = str1.ToLower().ToCharArray();
        char[] arr2 = str2.ToLower().ToCharArray();

        Array.Sort(arr1);
        Array.Sort(arr2);

        for (int i = 0; i < arr1.Length; i++)
        {
            if (arr1[i] != arr2[i])
                return false;
        }
        return true;
    }

    static void Main()
    {
        Console.WriteLine("Enter the first string:");
        string s1 = Console.ReadLine();

        Console.WriteLine("Enter the second string:");
        string s2 = Console.ReadLine();

        if (AreAnagrams(s1, s2))
            Console.WriteLine("The strings are anagrams.");
        else
            Console.WriteLine("The strings are not anagrams.");
    }
}