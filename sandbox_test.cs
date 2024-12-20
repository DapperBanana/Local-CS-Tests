
using System;

class Program
{
    static bool IsIsogram(string str)
    {
        // Create a boolean array to keep track of characters seen so far
        bool[] seen = new bool[256];

        foreach (char ch in str)
        {
            // If the character is already marked as seen, return false
            if (seen[char.ToLower(ch)]) 
            {
                return false;
            }

            // Mark the character as seen
            seen[char.ToLower(ch)] = true;
        }

        return true;
    }

    static void Main(string[] args)
    {
        string input = "hello";
        
        if (IsIsogram(input))
        {
            Console.WriteLine("The input string is an isogram.");
        }
        else
        {
            Console.WriteLine("The input string is not an isogram.");
        }
    }
}
