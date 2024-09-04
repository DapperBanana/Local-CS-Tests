
using System;

class Program
{
    static void Main()
    {
        string userInput;
        Console.WriteLine("Enter an ISBN number:");
        userInput = Console.ReadLine();

        if (IsValidISBN(userInput))
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
        // Remove any hyphens or spaces from ISBN
        isbn = isbn.Replace("-", "").Replace(" ", "");

        // Check if the ISBN is exactly 10 characters long
        if (isbn.Length != 10)
        {
            return false;
        }

        // Calculate the checksum
        int checksum = 0;
        for (int i = 0; i < 9; i++)
        {
            if (!char.IsDigit(isbn[i]))
            {
                return false;
            }
            checksum += int.Parse(isbn[i].ToString()) * (i + 1);
        }

        checksum %= 11;
        checksum = checksum == 10 ? 'X' : checksum + '0';

        // Compare the calculated checksum with the last digit of the ISBN
        return checksum == isbn[9];
    }
}
