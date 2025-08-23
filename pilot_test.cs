
using System;

class IsogramChecker
{
    static void Main()
    {
        string input = "example";

        if (IsIsogram(input))
        {
            Console.WriteLine("The input string is an isogram.");
        }
        else
        {
            Console.WriteLine("The input string is not an isogram.");
        }
    }

    static bool IsIsogram(string input)
    {
        for (int i = 0; i < input.Length; i++)
        {
            for (int j = i + 1; j < input.Length; j++)
            {
                if (char.ToLower(input[i]) == char.ToLower(input[j]))
                {
                    return false; // Found a duplicate character, not an isogram
                }
            }
        }

        return true; // No duplicate characters found, input is an isogram
    }
}
