
using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the first string:");
        string str1 = Console.ReadLine().ToLower();
        
        Console.WriteLine("Enter the second string:");
        string str2 = Console.ReadLine().ToLower();
        
        var commonChars = str1.Intersect(str2).ToList();
        
        Console.WriteLine("Common characters:");
        foreach (char c in commonChars)
        {
            Console.Write(c + " ");
        }
    }
}
