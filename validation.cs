
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        char[] inputArray = input.ToCharArray();
        Array.Reverse(inputArray);
        string reversedString = new String(inputArray);

        Console.WriteLine("Reversed string: " + reversedString);
    }
}
