
using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string str1 = "hello";
        string str2 = "world";

        var commonChars = FindCommonCharacters(str1, str2);

        Console.WriteLine("Common characters between '{0}' and '{1}': {2}", str1, str2, string.Join(", ", commonChars));
    }

    static List<char> FindCommonCharacters(string str1, string str2)
    {
        List<char> commonChars = str1.Intersect(str2).ToList();
        return commonChars;
    }
}
