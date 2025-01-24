
using System;

class VowelCounter
{
    static void Main()
    {
        string input;
        Console.Write("Enter a string: ");
        input = Console.ReadLine();

        int count = CountVowels(input);
        Console.WriteLine("Number of vowels: " + count);
    }

    static int CountVowels(string s)
    {
        int count = 0;
        foreach (char c in s)
        {
            if (IsVowel(c))
            {
                count++;
            }
        }
        return count;
    }

    static bool IsVowel(char c)
    {
        switch (Char.ToLower(c))
        {
            case 'a':
            case 'e':
            case 'i':
            case 'o':
            case 'u':
                return true;
            default:
                return false;
        }
    }
}
