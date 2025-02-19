
using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter an ISBN number:");
        string input = Console.ReadLine();

        if (IsValidISBN(input))
        {
            Console.WriteLine("Valid ISBN number");
        }
        else
        {
            Console.WriteLine("Invalid ISBN number");
        }
    }

    static bool IsValidISBN(string isbn)
    {
        // Remove any hyphens and spaces from the input string
        isbn = isbn.Replace("-", "").Replace(" ", "");

        // Check if the ISBN is of correct length
        if (isbn.Length != 10)
        {
            return false;
        }

        // Check if the ISBN contains only digits and 'X'
        if (!Regex.IsMatch(isbn, @"^\d{9}[0-9Xx]$"))
        {
            return false;
        }

        // Calculate the ISBN checksum
        int checksum = 0;
        for (int i = 0; i < 9; i++)
        {
            checksum += (i + 1) * int.Parse(isbn[i].ToString());
        }
        checksum %= 11;

        char lastDigit = isbn[9];
        if (lastDigit == 'X' || lastDigit == 'x')
        {
            return checksum == 10;
        }
        else
        {
            return checksum == int.Parse(lastDigit.ToString());
        }
    }
}
