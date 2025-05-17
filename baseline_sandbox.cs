
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter first string:");
        string str1 = Console.ReadLine().ToLower();
        
        Console.WriteLine("Enter second string:");
        string str2 = Console.ReadLine().ToLower();
        
        List<char> commonChars = new List<char>();
        
        foreach(char c in str1)
        {
            if(str2.Contains(c) && !commonChars.Contains(c))
            {
                commonChars.Add(c);
            }
        }
        
        Console.WriteLine("Common characters:");
        foreach(char c in commonChars)
        {
            Console.Write(c + " ");
        }
    }
}
