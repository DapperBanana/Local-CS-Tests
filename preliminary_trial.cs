
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter an ISBN number:");
        string input = Console.ReadLine();

        if (IsValidISBN(input))
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
        if (isbn.Length != 10)
        {
            return false;
        }

        int sum = 0;
        for (int i = 0; i < 9; i++)
        {
            if (!int.TryParse(isbn[i].ToString(), out int num))
            {
                return false;
            }
            sum += (i + 1) * num;
        }

        if (isbn[9] == 'X')
        {
            sum += 10;
        }
        else if (!int.TryParse(isbn[9].ToString(), out int lastNum))
        {
            return false;
        }
        else
        {
            sum += 10 * lastNum;
        }

        return sum % 11 == 0;
    }
}
