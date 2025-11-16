
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a sentence to check if it is a palindrome:");
        string input = Console.ReadLine();
        
        // Remove spaces and punctuation from the input string
        string cleanInput = new string(input.ToLower().ToCharArray()
                                .Where(c => Char.IsLetterOrDigit(c)).ToArray());
        
        // Check if the clean input string is a palindrome
        bool isPalindrome = IsPalindrome(cleanInput);
        
        if (isPalindrome)
        {
            Console.WriteLine("The input string is a palindrome!");
        }
        else
        {
            Console.WriteLine("The input string is not a palindrome.");
        }
    }
    
    static bool IsPalindrome(string str)
    {
        int left = 0;
        int right = str.Length - 1;
        
        while (left < right)
        {
            if (str[left] != str[right])
            {
                return false;
            }
            
            left++;
            right--;
        }
        
        return true;
    }
}
