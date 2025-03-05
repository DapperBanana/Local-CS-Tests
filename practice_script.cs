
using System;

class Program
{
    static bool IsAnagram(string str1, string str2)
    {
        // Check if the length of both strings is equal
        if (str1.Length != str2.Length)
        {
            return false;
        }

        // Convert the strings to character arrays
        char[] charArray1 = str1.ToCharArray();
        char[] charArray2 = str2.ToCharArray();

        // Sort the character arrays
        Array.Sort(charArray1);
        Array.Sort(charArray2);

        // Check if both character arrays are equal
        for (int i = 0; i < charArray1.Length; i++)
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
            Console.WriteLine($"{input1} is an anagram of {input2}");
        }
        else
        {
            Console.WriteLine($"{input1} is not an anagram of {input2}");
        }
    }
}
