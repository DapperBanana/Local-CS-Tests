
using System;

class Program
{
    static void Main()
    {
        string userInput;
        
        Console.Write("Enter a string: ");
        userInput = Console.ReadLine();
        
        if(IsPalindrome(userInput))
        {
            Console.WriteLine("The string is a palindrome.");
        }
        else
        {
            Console.WriteLine("The string is not a palindrome.");
        }
    }

    static bool IsPalindrome(string input)
    {
        string cleanInput = input.ToLower().Replace(" ", ""); // Remove spaces and convert to lowercase
        string reversedInput = "";

        for (int i = cleanInput.Length - 1; i >= 0; i--)
        {
            reversedInput += cleanInput[i];
        }

        if (cleanInput == reversedInput)
        {
            return true;
        }

        return false;
    }
}
