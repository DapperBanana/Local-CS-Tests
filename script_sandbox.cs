
using System;

class Program
{
    static void Main()
    {
        string isbn = "9780141036141"; // Change this to test different ISBN numbers
        Console.WriteLine($"Is '{isbn}' a valid ISBN number? {IsValidISBN(isbn)}");
    }

    static bool IsValidISBN(string isbn)
    {
        isbn = isbn.Replace("-", "").Replace(" ", ""); // Remove hyphens and spaces
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

            checksum += (i + 1) * digit;
        }

        if (isbn[9] == 'X')
        {
            checksum += 10;
        }
        else if (!int.TryParse(isbn[9].ToString(), out int lastDigit))
        {
            return false;
        }
        else
        {
            checksum += 10 * lastDigit;
        }

        return checksum % 11 == 0;
    }
}
