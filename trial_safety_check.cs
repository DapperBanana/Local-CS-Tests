
using System;

class Program
{
    static void Main()
    {
        string str = "Hello, World!";
        string reversedStr = ReverseString(str);
        
        Console.WriteLine("Original string: " + str);
        Console.WriteLine("Reversed string: " + reversedStr);
    }
    
    static string ReverseString(string str)
    {
        char[] charArray = str.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}
