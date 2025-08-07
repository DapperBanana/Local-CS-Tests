
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a string to reverse: ");
        string input = Console.ReadLine();

        string reversedString = ReverseString(input);

        Console.WriteLine("Reversed string: " + reversedString);
    }

    static string ReverseString(string str)
    {
        char[] charArray = str.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}
