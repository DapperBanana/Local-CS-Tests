
using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string isbn = "978-3-16-148410-0"; // Change this to the ISBN you want to check
        bool isValidISBN = CheckISBN(isbn);
        
        if (isValidISBN)
        {
            Console.WriteLine($"{isbn} is a valid ISBN number.");
        }
        else
        {
            Console.WriteLine($"{isbn} is not a valid ISBN number.");
        }
    }

    static bool CheckISBN(string isbn)
    {
        // Remove any hyphens or spaces from the ISBN
        isbn = isbn.Replace("-", "").Replace(" ", "");

        // Check if the length of the ISBN is either 10 or 13
        if (isbn.Length != 10 && isbn.Length != 13)
        {
            return false;
        }

        // Check if the ISBN contains only digits and a single 'x' character
        if (!Regex.IsMatch(isbn, @"^\d{9}[\dX]$") && !Regex.IsMatch(isbn, @"^\d{12}\d$"))
        {
            return false;
        }

        // Calculate the checksum for the ISBN
        int sum = 0;
        for (int i = 0; i < isbn.Length - 1; i++)
        {
            sum += int.Parse(isbn[i].ToString()) * (i + 1);
        }

        // Check if the checksum is valid for a 10-digit ISBN
        if (isbn.Length == 10)
        {
            if (isbn[9] == 'X')
            {
                sum += 10 * 10;
            }
            else
            {
                sum += int.Parse(isbn[9].ToString()) * 10;
            }

            if (sum % 11 == 0)
            {
                return true;
            }
        }
        // Check if the checksum is valid for a 13-digit ISBN
        else if (isbn.Length == 13 && sum % 10 == 0)
        {
            return true;
        }

        return false;
    }
}
