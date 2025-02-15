
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter an ISBN number:");
        string isbn = Console.ReadLine();

        if (IsISBNValid(isbn))
        {
            Console.WriteLine("The ISBN number is valid.");
        }
        else
        {
            Console.WriteLine("The ISBN number is not valid.");
        }
    }

    static bool IsISBNValid(string isbn)
    {
        // Remove any hyphens or spaces from the input string
        isbn = isbn.Replace("-", "").Replace(" ", "");

        // Check if the length of the ISBN is valid
        if (isbn.Length != 10)
        {
            return false;
        }

        // Calculate the checksum of the ISBN
        int checksum = 0;
        for (int i = 0; i < 9; i++)
        {
            if (int.TryParse(isbn[i].ToString(), out int digit))
            {
                checksum += digit * (10 - i);
            }
            else
            {
                return false;
            }
        }

        if (isbn[9] == 'X')
        {
            checksum += 10;
        }
        else if (int.TryParse(isbn[9].ToString(), out int lastDigit))
        {
            checksum += lastDigit;
        }
        else
        {
            return false;
        }

        // Check if the checksum is divisible by 11
        return checksum % 11 == 0;
    }
}
