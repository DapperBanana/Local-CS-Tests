
using System;

class Program
{
    static void Main()
    {
        string inputString, reversedString = "";
        
        Console.Write("Enter a string to reverse: ");
        inputString = Console.ReadLine();
        
        // Loop through the characters in the input string in reverse order
        for (int i = inputString.Length - 1; i >= 0; i--)
        {
            reversedString += inputString[i]; // Append each character to the reversed string
        }
        
        Console.WriteLine("Reversed string: " + reversedString);
    }
}
