
using System;

class Program
{
    static void Main()
    {
        string isbn = "0132350882"; // Change this to test different ISBNs

        bool isValidIsbn = IsISBN(isbn);

        if (isValidIsbn)
        {
            Console.WriteLine($"{isbn} is a valid ISBN number.");
        }
        else
        {
            Console.WriteLine($"{isbn} is not a valid ISBN number.");
        }
    }

    static bool IsISBN(string isbn)
    {
        // Remove any hyphens or spaces from the input
        isbn = isbn.Replace("-", "").Replace(" ", "");

        // Check if the input is 10 characters long
        if (isbn.Length != 10)
        {
            return false;
        }

        // Calculate the checksum value
        int checksum = 0;
        for (int i = 0; i < 9; i++)
        {
            checksum += (i + 1) * int.Parse(isbn[i].ToString());
        }

        // Check if the last character is valid
        if (isbn[9] == 'X')
        {
            checksum += 10;
        }
        else
        {
            checksum += int.Parse(isbn[9].ToString());
        }

        // Check if the checksum is valid
        return checksum % 11 == 0;
    }
}
