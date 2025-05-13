
using System;

class Program
{
    static bool IsValidCreditCardNumber(string input)
    {
        // Remove all non-digit characters from the input string
        input = new string(input.ToCharArray().Where(c => char.IsDigit(c)).ToArray());

        // Implement Luhn algorithm to validate credit card number
        int sum = 0;
        bool isEven = false;

        for (int i = input.Length - 1; i >= 0; i--)
        {
            int digit = input[i] - '0';

            if (isEven)
            {
                digit *= 2;
                if (digit > 9)
                {
                    digit -= 9;
                }
            }

            sum += digit;
            isEven = !isEven;
        }

        return sum % 10 == 0;
    }

    static void Main()
    {
        Console.WriteLine("Enter a credit card number: ");
        string input = Console.ReadLine();

        if (IsValidCreditCardNumber(input))
        {
            Console.WriteLine("Valid credit card number!");
        }
        else
        {
            Console.WriteLine("Invalid credit card number.");
        }
    }
}
