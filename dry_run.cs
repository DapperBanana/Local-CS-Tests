
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter an ISBN number: ");
        string isbn = Console.ReadLine();

        if (IsValidISBN(isbn))
        {
            Console.WriteLine("Valid ISBN number.");
        }
        else
        {
            Console.WriteLine("Invalid ISBN number.");
        }
    }

    static bool IsValidISBN(string isbn)
    {
        // Remove any hyphens or spaces from the ISBN
        isbn = isbn.Replace("-", "").Replace(" ", "");

        // Check if the ISBN is 10 or 13 characters long
        if (isbn.Length != 10 && isbn.Length != 13)
        {
            return false;
        }

        // Check if the ISBN contains only digits and a possible 'X' at the end (for ISBN-10)
        foreach (char c in isbn)
        {
            if (!char.IsDigit(c) && !(c == 'X' && isbn.IndexOf(c) == isbn.Length - 1))
            {
                return false;
            }
        }

        // Check the checksum for ISBN-10
        if (isbn.Length == 10)
        {
            int checksum = 0;
            for (int i = 0; i < 9; i++)
            {
                checksum += (i + 1) * int.Parse(isbn[i].ToString());
            }
            checksum %= 11;
            char lastChar = isbn[9];
            if (checksum == 10)
            {
                return lastChar == 'X';
            }
            else
            {
                return checksum == int.Parse(lastChar.ToString());
            }
        }

        // Check the checksum for ISBN-13
        if (isbn.Length == 13)
        {
            int checksum = 0;
            for (int i = 0; i < 12; i++)
            {
                int digit = int.Parse(isbn[i].ToString());
                checksum += (i % 2 == 0) ? digit : digit * 3;
            }
            checksum %= 10;
            int checkDigit = 10 - checksum;
            if (checkDigit == 10)
            {
                return isbn[12] == '0';
            }
            else
            {
                return int.Parse(isbn[12].ToString()) == checkDigit;
            }
        }

        return false;
    }
}
