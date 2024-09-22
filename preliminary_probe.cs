
using System;

class Program
{
    static void Main()
    {
        string input = "ISBN number to validate"; //Enter the ISBN number here

        if (IsISBNValid(input))
        {
            Console.WriteLine($"{input} is a valid ISBN number.");
        }
        else
        {
            Console.WriteLine($"{input} is not a valid ISBN number.");
        }
    }

    static bool IsISBNValid(string isbn)
    {
        // Remove any dashes or spaces from the input string
        isbn = isbn.Replace("-", "").Replace(" ", "");

        // Check if the length of the string is 10 or 13
        if (isbn.Length != 10 && isbn.Length != 13)
        {
            return false;
        }

        // Calculate the checksum for the ISBN number based on its length
        if (isbn.Length == 10)
        {
            int sum = 0;
            for (int i = 0; i < isbn.Length; i++)
            {
                if (!char.IsDigit(isbn[i]) && i != isbn.Length - 1 && isbn[i] != 'X')
                {
                    return false;
                }

                if (i == isbn.Length - 1 && isbn[i] == 'X')
                {
                    sum += 10;
                }
                else
                {
                    sum += int.Parse(isbn[i].ToString()) * (i + 1);
                }
            }

            return sum % 11 == 0;
        }
        else if (isbn.Length == 13)
        {
            int sum = 0;
            for (int i = 0; i < isbn.Length; i++)
            {
                if (!char.IsDigit(isbn[i]))
                {
                    return false;
                }

                sum += int.Parse(isbn[i].ToString()) * (i % 2 == 0 ? 1 : 3);
            }

            return sum % 10 == 0;
        }

        return false;
    }
}
