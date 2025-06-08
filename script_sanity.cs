
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter an ISBN number:");
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
        isbn = isbn.Replace("-", "").Replace(" ",""); // Remove any dashes or spaces
        
        if (isbn.Length != 10)
        {
            return false;
        }

        int checksum = 0;
        for (int i = 0; i < 9; i++)
        {
            if (!char.IsDigit(isbn[i]))
            {
                return false;
            }
            checksum += (i + 1) * int.Parse(isbn[i].ToString());
        }

        if (isbn[9] == 'X')
        {
            checksum += 10;
        }
        else if(!char.IsDigit(isbn[9]))
        {
            return false;
        }
        else
        {
            checksum += 10 * int.Parse(isbn[9].ToString());
        }

        return checksum % 11 == 0;
    }
}
