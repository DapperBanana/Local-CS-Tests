
using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string input = "123456789X"; // Change this string to the ISBN number you want to check
        
        if (IsValidIsbn(input))
        {
            Console.WriteLine($"{input} is a valid ISBN number.");
        }
        else
        {
            Console.WriteLine($"{input} is not a valid ISBN number.");
        }
    }

    static bool IsValidIsbn(string isbn)
    {
        isbn = isbn.Replace("-", ""); // Remove any dashes from the ISBN number

        if (isbn.Length != 10)
        {
            return false;
        }

        // Calculate the sum of the ISBN digits with weight
        int sum = 0;
        for (int i = 0; i < 9; i++)
        {
            if (!int.TryParse(isbn[i].ToString(), out int digit))
            {
                return false;
            }
            sum += (i + 1) * digit;
        }

        // Calculate the check digit
        char checkDigit = isbn[9];
        int checkValue = (checkDigit == 'X') ? 10 : int.Parse(checkDigit.ToString());

        int checksum = sum % 11;
        
        return (checksum == checkValue);
    }
}
