
using System;

class Program
{
    static void Main()
    {
        string input = "1234567890"; //change this to the desired ISBN number
        bool isValid = IsValidISBN(input);
        
        if (isValid)
        {
            Console.WriteLine("The given string is a valid ISBN number.");
        }
        else
        {
            Console.WriteLine("The given string is not a valid ISBN number.");
        }
    }

    static bool IsValidISBN(string isbn)
    {
        int length = isbn.Length;
        
        if (length != 10)
        {
            return false;
        }

        int sum = 0;
        for (int i = 0; i < length; i++)
        {
            if (isbn[i] == 'X' && i == 9)
            {
                sum += 10;
            }
            else
            {
                int digit;
                if (!int.TryParse(isbn[i].ToString(), out digit))
                {
                    return false; // not a valid digit
                }
                sum += digit * (length - i);
            }
        }

        return sum % 11 == 0;
    }
}
