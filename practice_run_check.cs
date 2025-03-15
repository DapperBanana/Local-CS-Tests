
using System;
using System.Linq;

class Program
{
    static void Main()
    {
        string str1 = "hello";
        string str2 = "world";
        
        var commonChars = str1.Intersect(str2).ToList();
        
        Console.WriteLine("Common characters between the two strings:");
        foreach(var c in commonChars)
        {
            Console.WriteLine(c);
        }
    }
}
