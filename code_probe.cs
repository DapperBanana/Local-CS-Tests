
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a string to reverse: ");
        string inputString = Console.ReadLine();
        
        string reversedString = ReverseString(inputString);
        
        Console.WriteLine("Reversed string: " + reversedString);
    }
    
    static string ReverseString(string input)
    {
        char[] charArray = input.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}
