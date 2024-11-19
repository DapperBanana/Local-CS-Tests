
using System;

class Program
{
    static bool IsValidISBN(string isbn)
    {
        // Remove any hyphens from the input string
        isbn = isbn.Replace("-", "");

        // Check that the ISBN is either 10 or 13 characters long
        if (isbn.Length != 10 && isbn.Length != 13)
        {
            return false;
        }

        // Compute the check digit for ISBN-10
        if (isbn.Length == 10)
        {
            int sum = 0;
            for (int i = 0; i < 9; i++)
            {
                sum += (i + 1) * int.Parse(isbn[i].ToString());
            }

            int checkDigit = sum % 11;
            if (checkDigit == 10)
            {
                return isbn[9] == 'X';
            }
            else
            {
                return int.Parse(isbn[9].ToString()) == checkDigit;
            }
        }

        // Compute the check digit for ISBN-13
        if (isbn.Length == 13)
        {
            int sum = 0;
            for (int i = 0; i < 12; i++)
            {
                sum += int.Parse(isbn[i].ToString()) * (i % 2 == 0 ? 1 : 3);
            }

            int checkDigit = (10 - (sum % 10)) % 10;
            return int.Parse(isbn[12].ToString()) == checkDigit;
        }

        return false;
    }

    static void Main()
    {
        Console.Write("Enter an ISBN number: ");
        string isbn = Console.ReadLine();

        if (IsValidISBN(isbn))
        {
            Console.WriteLine("The ISBN number is valid.");
        }
        else
        {
            Console.WriteLine("The ISBN number is invalid.");
        }
    }
}
