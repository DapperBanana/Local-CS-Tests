
using System;
using System.Linq;

class Program
{
    static void Main()
    {
        string str = "hello";
        
        if (IsIsogram(str))
        {
            Console.WriteLine($"{str} is an isogram.");
        }
        else
        {
            Console.WriteLine($"{str} is not an isogram.");
        }
    }

    static bool IsIsogram(string str)
    {
        // Convert the string to lowercase to handle case-insensitive isograms
        str = str.ToLower();

        // Create a distinct list of characters in the string
        var distinctChars = str.Distinct();

        // Compare the count of distinct characters with the length of the original string
        if (distinctChars.Count() == str.Length)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
