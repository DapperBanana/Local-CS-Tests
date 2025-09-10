
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
            Console.WriteLine("Valid ISBN number");
        }
        else
        {
            Console.WriteLine("Invalid ISBN number");
        }
    }

    static bool IsValidISBN(string isbn)
    {
        isbn = isbn.Replace("-", "").Replace(" ", ""); // Remove any dashes or spaces

        if (isbn.Length != 10)
        {
            return false;
        }

        int checksum = 0;
        for (int i = 0; i < isbn.Length; i++)
        {
            int digit;
            if (isbn[i] == 'X' && i == 9)
            {
                digit = 10;
            }
            else if (!int.TryParse(isbn[i].ToString(), out digit))
            {
                return false;
            }

            checksum += digit * (10 - i);
        }

        return checksum % 11 == 0;
    }
}
