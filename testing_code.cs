
using System;

class Program
{
    static void Main()
    {
        string isbn = "123456789X"; // Change this to test different ISBN numbers
        bool isValid = ValidateISBN(isbn);
        
        if(isValid)
        {
            Console.WriteLine($"{isbn} is a valid ISBN number.");
        }
        else
        {
            Console.WriteLine($"{isbn} is not a valid ISBN number.");
        }
    }
    
    static bool ValidateISBN(string isbn)
    {
        // Remove any dashes, spaces, or other special characters from the ISBN string
        isbn = isbn.Replace("-", "").Replace(" ", "").Replace("X", "");
        
        if(isbn.Length != 10)
        {
            return false;
        }
        
        int sum = 0;
        
        for(int i = 0; i < 9; i++)
        {
            int digit;
            if(!int.TryParse(isbn[i].ToString(), out digit))
            {
                return false;
            }
            
            sum += digit * (10 - i);
        }
        
        if(isbn[9] == 'X')
        {
            sum += 10;
        }
        else
        {
            if(!int.TryParse(isbn[9].ToString(), out int lastDigit))
            {
                return false;
            }
            
            sum += lastDigit;
        }
        
        return sum % 11 == 0;
    }
}
