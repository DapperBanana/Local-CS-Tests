
using System;

class PalindromeChecker
{
    static bool IsPalindrome(string str)
    {
        string cleanStr = "";
        
        foreach (char c in str.ToLower())
        {
            if (char.IsLetter(c))
            {
                cleanStr += c;
            }
        }
        
        int left = 0;
        int right = cleanStr.Length - 1;
        
        while (left < right)
        {
            if (cleanStr[left] != cleanStr[right])
            {
                return false;
            }
            
            left++;
            right--;
        }
        
        return true;
    }
    
    static void Main()
    {
        Console.Write("Enter a sentence: ");
        string sentence = Console.ReadLine();
        
        if (IsPalindrome(sentence))
        {
            Console.WriteLine("The sentence is a valid palindrome.");
        }
        else
        {
            Console.WriteLine("The sentence is not a palindrome.");
        }
    }
}
