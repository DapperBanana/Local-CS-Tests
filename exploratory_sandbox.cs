
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter an ISBN number: ");
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
        // Remove any hyphens or spaces
        isbn = isbn.Replace("-", "").Replace(" ", "");

        // Check if the ISBN number has exactly 10 digits
        if (isbn.Length != 10)
        {
            return false;
        }

        // Calculate the checksum
        int sum = 0;
        for (int i = 0; i < 9; i++)
        {
            if (!char.IsDigit(isbn[i]))
            {
                return false;
            }
            sum += (i + 1) * int.Parse(isbn[i].ToString());
        }

        char lastChar = isbn[9];
        if (lastChar != 'X' && !char.IsDigit(lastChar))
        {
            return false;
        }

        int lastDigit = lastChar == 'X' ? 10 : int.Parse(lastChar.ToString());

        return (sum + lastDigit) % 11 == 0;
    }
}
