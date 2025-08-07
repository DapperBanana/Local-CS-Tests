
using System;

class Program
{
    public static bool IsValidISBN(string isbn)
    {
        // Remove any '-' or space characters from the string
        var cleanISBN = isbn.Replace("-", "").Replace(" ", "");

        // Check the length of the cleaned up ISBN
        if (cleanISBN.Length != 10)
        {
            return false;
        }

        // Calculate the sum of the ISBN digits
        int sum = 0;
        for (int i = 0; i < 9; i++)
        {
            if (!int.TryParse(cleanISBN[i].ToString(), out int digit))
            {
                return false;
            }
            sum += (i + 1) * digit;
        }

        char lastChar = cleanISBN[9];
        int lastDigit = 0;
        if (char.ToUpper(lastChar) == 'X')
        {
            lastDigit = 10;
        }
        else if (!int.TryParse(lastChar.ToString(), out lastDigit))
        {
            return false;
        }

        sum += 10 * lastDigit;

        // Check if the sum is divisible by 11
        return sum % 11 == 0;
    }

    static void Main()
    {
        string isbn = "0-306-40615-2";

        if (IsValidISBN(isbn))
        {
            Console.WriteLine($"{isbn} is a valid ISBN number.");
        }
        else
        {
            Console.WriteLine($"{isbn} is not a valid ISBN number.");
        }

        Console.ReadLine();
    }
}
