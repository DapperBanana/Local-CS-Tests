
using System;

class Program
{
    static void Main()
    {
        string inputString;
        int vowelCount = 0;

        Console.WriteLine("Enter a string: ");
        inputString = Console.ReadLine();

        foreach (char c in inputString)
        {
            if (IsVowel(c))
            {
                vowelCount++;
            }
        }

        Console.WriteLine("Number of vowels in the string: " + vowelCount);
    }

    static bool IsVowel(char c)
    {
        char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };

        foreach (char vowel in vowels)
        {
            if (c == vowel)
            {
                return true;
            }
        }

        return false;
    }
}
