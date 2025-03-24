
using System;
using System.Linq;

class Program
{
    static bool IsAnagram(string str1, string str2)
    {
        if (str1.Length != str2.Length)
        {
            return false;
        }

        char[] charArray1 = str1.ToLower().ToCharArray();
        char[] charArray2 = str2.ToLower().ToCharArray();

        Array.Sort(charArray1);
        Array.Sort(charArray2);

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
            Console.WriteLine($"{input1} and {input2} are anagrams.");
        }
        else
        {
            Console.WriteLine($"{input1} and {input2} are not anagrams.");
        }
    }
}
