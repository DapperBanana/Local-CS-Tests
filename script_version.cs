
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter an ISBN number:");
        string isbn = Console.ReadLine();

        bool isValidISBN = IsValidISBN(isbn);

        if (isValidISBN)
        {
            Console.WriteLine("The entered ISBN is valid.");
        }
        else
        {
            Console.WriteLine("The entered ISBN is not valid.");
        }
    }

    static bool IsValidISBN(string isbn)
    {
        // Remove any hyphens from the input ISBN
        isbn = isbn.Replace("-", "");

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

        char lastCharacter = isbn[9];
        if (lastCharacter == 'X' || lastCharacter == 'x')
        {
            checksum += 10;
        }
        else
        {
            int lastDigit;
            if (!int.TryParse(lastCharacter.ToString(), out lastDigit))
            {
                return false;
            }
            checksum += lastDigit;
        }

        return checksum % 11 == 0;
    }
}
