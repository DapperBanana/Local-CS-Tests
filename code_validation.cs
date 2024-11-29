
using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string isbn = "123456789X"; // Enter the ISBN number to check here

        if (IsValidISBN(isbn))
        {
            Console.WriteLine($"The ISBN number {isbn} is valid.");
        }
        else
        {
            Console.WriteLine($"The ISBN number {isbn} is not valid.");
        }
    }

    public static bool IsValidISBN(string isbn)
    {
        // Remove any hyphens or spaces from the input string
        isbn = isbn.Replace("-", "").Replace(" ", "");

        // Check if the input string matches the ISBN-10 format
        if (Regex.IsMatch(isbn, @"^\d{9}[0-9X]$"))
        {
            int sum = 0;
            int weight = 10;

            // Calculate the weighted sum of the digits in the ISBN
            for (int i = 0; i < 9; i++)
            {
                if (isbn[i] == 'X')
                {
                    sum += 10 * weight;
                }
                else
                {
                    sum += (int)Char.GetNumericValue(isbn[i]) * weight;
                }
                weight--;
            }

            // Calculate the check digit
            int checkDigit = sum % 11;

            // Check if the check digit is valid
            if (checkDigit == 0)
            {
                return isbn[9] == '0';
            }
            else
            {
                return isbn[9] == (11 - checkDigit).ToString()[0];
            }
        }

        return false;
    }
}
