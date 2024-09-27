
using System;

class PalindromeChecker
{
    static void Main()
    {
        Console.Write("Enter a string to check if it is a palindrome: ");
        string inputString = Console.ReadLine();
        
        if(IsPalindrome(inputString))
        {
            Console.WriteLine("Yes, the input string is a palindrome.");
        }
        else
        {
            Console.WriteLine("No, the input string is not a palindrome.");
        }
    }
    
    static bool IsPalindrome(string str)
    {
        int left = 0;
        int right = str.Length - 1;
        
        while(left < right)
        {
            if(str[left] != str[right])
            {
                return false;
            }
            
            left++;
            right--;
        }
        
        return true;
    }
}
