
using System;

class StringReversal
{
    static void Main()
    {
        string inputString, reversedString = "";

        // Input the string to be reversed
        Console.Write("Enter a string: ");
        inputString = Console.ReadLine();

        // Reverse the string
        for (int i = inputString.Length - 1; i >= 0; i--)
        {
            reversedString += inputString[i];
        }

        // Display the reversed string
        Console.WriteLine("Reversed string: " + reversedString);
    }
}
