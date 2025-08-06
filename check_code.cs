
using System;

class Program
{
    static void Main()
    {
        string isbn = "0140449116";
        bool isValid = ValidateISBN(isbn);
        
        if (isValid)
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
        if (isbn.Length != 10)
        {
            return false;
        }
        
        int checksum = 0;
        
        for (int i = 0; i < 9; i++)
        {
            int digit;
            if (!int.TryParse(isbn[i].ToString(), out digit))
            {
                return false;
            }
            
            checksum += digit * (10 - i);
        }
        
        char lastChar = isbn[9];
        int lastDigit = (lastChar == 'X') ? 10 : int.Parse(lastChar.ToString());
        
        checksum += lastDigit;
        
        return checksum % 11 == 0;
    }
}
