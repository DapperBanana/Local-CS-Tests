
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a string:");
        string input = Console.ReadLine();

        int count = CountVowels(input);
        Console.WriteLine("Number of vowels in the string: " + count);
    }

    static int CountVowels(string str)
    {
        int count = 0;
        foreach (char c in str.ToLower())
        {
            if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
            {
                count++;
            }
        }
        return count;
    }
}
