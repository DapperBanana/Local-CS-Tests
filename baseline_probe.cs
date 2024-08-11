
using System;
using System.Linq;

class AnagramChecker
{
    static bool AreAnagrams(string str1, string str2)
    {
        if (str1.Length != str2.Length)
        {
            return false;
        }

        str1 = String.Concat(str1.OrderBy(c => c));
        str2 = String.Concat(str2.OrderBy(c => c));

        return str1.Equals(str2);
    }

    static void Main()
    {
        Console.WriteLine("Enter the first string: ");
        string str1 = Console.ReadLine();

        Console.WriteLine("Enter the second string: ");
        string str2 = Console.ReadLine();

        if (AreAnagrams(str1, str2))
        {
            Console.WriteLine("The two strings are anagrams of each other.");
        }
        else
        {
            Console.WriteLine("The two strings are not anagrams of each other.");
        }
    }
}
