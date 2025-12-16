using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a string:");
        string input = Console.ReadLine();

        int vowelCount = CountVowels(input);
        Console.WriteLine($"Number of vowels: {vowelCount}");
    }

    static int CountVowels(string str)
    {
        int count = 0;
        string vowels = "aeiouAEIOU";

        foreach (char c in str)
        {
            if (vowels.Contains(c))
            {
                count++;
            }
        }

        return count;
    }
}