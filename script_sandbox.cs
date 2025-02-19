
using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        Console.Write("Enter the ISBN number: ");
        string isbn = Console.ReadLine();

        if (IsValidISBN(isbn))
        {
            Console.WriteLine("The entered ISBN number is valid.");
        }
        else
        {
            Console.WriteLine("The entered ISBN number is invalid.");
        }
    }

    static bool IsValidISBN(string isbn)
    {
        // Remove any dashes or spaces from the ISBN
        isbn = isbn.Replace("-", "").Replace(" ", "");

        // Check if the ISBN is 10 or 13 characters long
        if (isbn.Length != 10 && isbn.Length != 13) return false;

        // Check if the ISBN contains only digits and the last character can be 'X' for ISBN-10
        if (!Regex.IsMatch(isbn, "^[0-9X]+$")) return false;

        // Calculate the ISBN checksum
        int checksum = 0;
        for (int i = 0; i < isbn.Length - 1; i++)
        {
            int digit = isbn[i] == 'X' ? 10 : (int)char.GetNumericValue(isbn[i]);
            checksum += digit * (isbn.Length - i);
        }

        // For ISBN-10, the checksum should be divisible by 11
        if (isbn.Length == 10 && checksum % 11 != 0) return false;

        // For ISBN-13, the checksum should be divisible by 10
        if (isbn.Length == 13 && checksum % 10 != 0) return false;

        return true;
    }
}
