using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the first string:");
        string str1 = Console.ReadLine();

        Console.WriteLine("Enter the second string:");
        string str2 = Console.ReadLine();

        bool result = AreAnagrams(str1, str2);
        Console.WriteLine(result ? "They are anagrams." : "They are not anagrams.");
    }

    static bool AreAnagrams(string s1, string s2)
    {
        // Remove whitespace and convert to lowercase for comparison
        var processedS1 = new string(s1.Where(c => !char.IsWhiteSpace(c)).ToArray()).ToLower();
        var processedS2 = new string(s2.Where(c => !char.IsWhiteSpace(c)).ToArray()).ToLower();

        // Check if sorted characters are equal
        return processedS1.OrderBy(c => c).SequenceEqual(processedS2.OrderBy(c => c));
    }
}