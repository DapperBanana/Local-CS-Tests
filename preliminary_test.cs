
using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string isbn = "978-3-16-148410-0";

        bool isValid = IsValidISBN(isbn);

        if (isValid)
        {
            Console.WriteLine("The ISBN number is valid.");
        }
        else
        {
            Console.WriteLine("The ISBN number is not valid.");
        }
    }

    static bool IsValidISBN(string isbn)
    {
        isbn = isbn.Replace("-", ""); // Remove any dashes

        // Check if the ISBN is of the correct format
        if (!Regex.IsMatch(isbn, @"^\d{9}[\d|X]$"))
        {
            return false;
        }

        // Calculate the check digit
        int sum = 0;
        for (int i = 0; i < 9; i++)
        {
            sum += (int)Char.GetNumericValue(isbn[i]) * (i + 1);
        }

        int checkDigit = isbn[9] == 'X' ? 10 : (int)Char.GetNumericValue(isbn[9]);

        return sum % 11 == checkDigit;
    }
}
