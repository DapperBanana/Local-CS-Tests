
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a string to reverse:");
        string input = Console.ReadLine();

        char[] charArray = input.ToCharArray();
        Array.Reverse(charArray);

        string reversedString = new string(charArray);

        Console.WriteLine("Reversed string: " + reversedString);
    }
}
