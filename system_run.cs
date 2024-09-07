
using System;
using System.Text.RegularExpressions;

class Program
{
    public static bool IsValidISBN(string isbn)
    {
        // Remove any hyphens or spaces from the ISBN
        string cleanedISBN = Regex.Replace(isbn, @"[\s-]", "");
        
        // Check if the cleaned ISBN is of length 10 or 13
        if (cleanedISBN.Length != 10 && cleanedISBN.Length != 13)
        {
            return false;
        }
        
        // Validate 10-digit ISBN
        if (cleanedISBN.Length == 10)
        {
            int sum = 0;
            for (int i = 0; i < 9; i++)
            {
                sum += (int)Char.GetNumericValue(cleanedISBN[i]) * (i + 1);
            }

            char checkDigit = cleanedISBN[9];
            int lastDigitValue = (checkDigit == 'X') ? 10 : (int)Char.GetNumericValue(checkDigit);

            return sum % 11 == lastDigitValue;
        }
        
        // Validate 13-digit ISBN
        if (cleanedISBN.Length == 13)
        {
            int sum = 0;
            for (int i = 0; i < 12; i++)
            {
                int weight = (i % 2 == 0) ? 1 : 3;
                sum += (int)Char.GetNumericValue(cleanedISBN[i]) * weight;
            }

            int checkDigit = (10 - (sum % 10)) % 10;
            return checkDigit == (int)Char.GetNumericValue(cleanedISBN[12]);
        }

        return false;
    }
    
    static void Main()
    {
        string inputISBN = "978-3-16-148410-0";
        
        bool isValid = IsValidISBN(inputISBN);
        
        if (isValid)
        {
            Console.WriteLine("The input ISBN is valid.");
        }
        else
        {
            Console.WriteLine("The input ISBN is not valid.");
        }
    }
}

