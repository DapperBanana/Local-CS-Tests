
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter an ISBN number: ");
        string isbn = Console.ReadLine();

        bool isValid = IsValidISBN(isbn);

        if (isValid)
        {
            Console.WriteLine($"{isbn} is a valid ISBN number.");
        }
        else
        {
            Console.WriteLine($"{isbn} is not a valid ISBN number.");
        }
    }

    static bool IsValidISBN(string isbn)
    {
        isbn = isbn.Replace("-", "").Replace(" ", "");

        if (isbn.Length != 10)
        {
            return false;
        }

        int sum = 0;
        for (int i = 0; i < 9; i++)
        {
            if (!int.TryParse(isbn[i].ToString(), out int digit))
            {
                return false;
            }
            sum += digit * (i + 1);
        }

        if (isbn[9] == 'X' || isbn[9] == 'x')
            sum += 10;
        else if (!int.TryParse(isbn[9].ToString(), out int lastDigit))
            return false;
        else
            sum += lastDigit * 10;

        return sum % 11 == 0;
    }
}
