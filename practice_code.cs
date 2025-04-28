
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string str1 = "hello";
        string str2 = "world";
        
        List<char> commonChars = FindCommonCharacters(str1, str2);
        
        Console.WriteLine("Common characters between \"" + str1 + "\" and \"" + str2 + "\": ");
        foreach (char c in commonChars)
        {
            Console.Write(c + " ");
        }
    }
    
    static List<char> FindCommonCharacters(string str1, string str2)
    {
        List<char> commonChars = new List<char>();
        HashSet<char> set = new HashSet<char>();
        
        foreach (char c in str1)
        {
            set.Add(c);
        }
        
        foreach (char c in str2)
        {
            if (set.Contains(c))
            {
                commonChars.Add(c);
                set.Remove(c);
            }
        }
        
        return commonChars;
    }
}
