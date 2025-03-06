
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a string:");
        string input = Console.ReadLine();

        int vowelCount = CountVowels(input);

        Console.WriteLine("Number of vowels in the given string: " + vowelCount);
    }

    static int CountVowels(string str)
    {
        int count = 0;
        foreach (char c in str)
        {
            if ("AEIOUaeiou".IndexOf(c) >= 0)
            {
                count++;
            }
        }
        return count;
    }
}
