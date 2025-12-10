using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        string str1 = "hello world";
        string str2 = "world peace";

        // Find common characters
        var commonChars = GetCommonCharacters(str1, str2);

        // Print the common characters
        Console.WriteLine("Common characters: " + new string(commonChars.ToArray()));
    }

    static List<char> GetCommonCharacters(string s1, string s2)
    {
        var set1 = new HashSet<char>(s1);
        var set2 = new HashSet<char>(s2);

        // Intersection of the two sets
        set1.IntersectWith(set2);

        // Return as a list
        return set1.ToList();
    }
}